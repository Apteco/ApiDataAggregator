using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public class CubesService
  {
    #region private class CubeDimensionHeaders
    private class CubeDimensionHeaders
    {
      #region private fields
      private string[][] dimensionHeaders;
      #endregion

      #region public properties
      public int NumberOfDimensions
      {
        get { return dimensionHeaders.Length; }
      }
      #endregion

      #region public constructor
      public CubeDimensionHeaders(List<DimensionResult> dimensionResults)
      {
        dimensionHeaders = dimensionResults
            .Select(d => d.HeaderDescriptions.Split('\t'))
            .ToArray();
      }
      #endregion

      #region public methods
      public int GetDimensionLength(int dimensionIndex)
      {
        return dimensionHeaders[dimensionIndex].Length;
      }

      public string GetDimensionHeader(int dimensionIndex, int itemIndex)
      {
        return dimensionHeaders[dimensionIndex][itemIndex];
      }

      public int GetItemIndex(int rowIndex, int dimensionIndex)
      {
        if (dimensionIndex < 1)
          return -1;

        int multiplier = dimensionHeaders.Skip(1).Take(dimensionIndex - 1).Aggregate(1, (total, headers) => total * headers.Length);
        return ((int)Math.Floor(rowIndex / (double)multiplier)) % dimensionHeaders[dimensionIndex].Length;
      }
      #endregion
    }
    #endregion

    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public CubesService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<List<string>> CalculateCube(string systemName, SessionDetails sessionDetails, Query baseQuery, List<Dimension> dimensions, List<Measure> measures, TimeSpan timeout)
    {
      if (baseQuery?.Selection?.TableName == null)
        throw new ArgumentException("The specified baseQuery must have at least a selection with a table name in order for it to be a valid query", nameof(baseQuery));

      ICubesApi cubesApi = connectorFactory.CreateCubesApi(sessionDetails);

      Cube cube = new Cube(
        BaseQuery: baseQuery,
        ResolveTableName: baseQuery.Selection.TableName,
        Storage: Cube.StorageEnum.Full,
        Dimensions: dimensions,
        Measures: measures);

      CubeResult cubeResult = await cubesApi.CubesCalculateCubeSynchronouslyAsync(dataViewName, systemName, cube, (int)timeout.TotalSeconds, true);

      List<string> data = new List<string>();

      if (cubeResult?.MeasureResults != null)
      {
        for (int measureIndex = 0; measureIndex < cubeResult.MeasureResults.Count; measureIndex++)
        {
          MeasureResult measureResult = cubeResult.MeasureResults[measureIndex];
          Measure measure = measures[measureIndex];

          AddMeaureToData(data, measure, measureResult, cubeResult.DimensionResults);
          data.Add("");
        }
      }

      return data;
    }
    #endregion

    #region private methods
    private void AddMeaureToData(List<string> data, Measure measure, MeasureResult measureResult, List<DimensionResult> dimensionResults)
    {
      //The CubeDimensionHeaders private class is used to convert an n-dimensional cube into a series of 2D tables to output.
      CubeDimensionHeaders cubeDimensionHeaders = new CubeDimensionHeaders(dimensionResults);

      if (measureResult.Rows.Count < 1)
        return;

      data.Add(GetMeasureDescription(measure));
      if (measureResult.Rows.Count == 1)
      {
        data.Add(dimensionResults[0].HeaderDescriptions);
        data.Add(measureResult.Rows[0]);
        return;
      }

      for (int rowIndex = 0; rowIndex < measureResult.Rows.Count; rowIndex++)
      {
        int dimension1Index = cubeDimensionHeaders.GetItemIndex(rowIndex, 1);
        if (dimension1Index == 0)
        {
          data.Add("");
          data.Add(GetSubCubeDescription(rowIndex, cubeDimensionHeaders));
          data.Add("\t" + dimensionResults[0].HeaderDescriptions);
        }
        data.Add(cubeDimensionHeaders.GetDimensionHeader(1, dimension1Index) + "\t" + measureResult.Rows[rowIndex]);
      }
    }

    private string GetMeasureDescription(Measure measure)
    {
      switch (measure.Function)
      {
        case Measure.FunctionEnum.Count:
          return $"{measure.Function} of {measure.ResolveTableName}";

        default:
          return $"{measure.Function} of {measure.VariableName}";
      }
    }

    //Get the name of each 2D cube, by finding the points of each dimension bigger then the first 2D.
    private string GetSubCubeDescription(int rowIndex, CubeDimensionHeaders cubeDimensionHeaders)
    {
      List<string> descriptions = new List<string>();
      for (int dimensionIndex = cubeDimensionHeaders.NumberOfDimensions - 1; dimensionIndex > 1; dimensionIndex--)
      {
        int itemIndex = cubeDimensionHeaders.GetItemIndex(rowIndex, dimensionIndex);
        descriptions.Add(cubeDimensionHeaders.GetDimensionHeader(dimensionIndex, itemIndex));
      }
      return String.Join(", ", descriptions);
    }
    #endregion
  }
}
