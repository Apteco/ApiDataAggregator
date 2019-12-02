using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Model;
using Apteco.ApiDataAggregator.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiDataAggregator.Core
{
  public class DataAggregator
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    private ILogger<DataAggregator> logger;
    #endregion

    #region public constructor
    public DataAggregator(IApiConnectorFactory connectorFactory, string dataViewName, ILogger<DataAggregator> logger)
    {
      this.dataViewName = dataViewName;
      this.connectorFactory = connectorFactory;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public async Task<bool> TryShowCubeForVariables(SessionDetails sessionDetails, string systemName, string queryFilePath, List<string> variableNames, TextWriter outputWriter)
    {
      QueriesService queriesService = new QueriesService(connectorFactory, dataViewName);
      Query query = await queriesService.GetQueryDefinitionFromFile(systemName, sessionDetails, queryFilePath, TimeSpan.FromMinutes(5));
      if (query == null)
        return false;

      if (query?.Selection?.TableName == null)
        throw new Exception($"The query {queryFilePath} must have at least a selection with a table name");

      FastStatsSystemService fastStatsSystemService = new FastStatsSystemService(connectorFactory, dataViewName);
      foreach (string variableName in variableNames)
      {
        Variable variable = await fastStatsSystemService.GetVariable(sessionDetails, systemName, variableName);
        if (variable == null)
          throw new Exception($"Couldn't find a variable with the name {variableName} in the system {systemName}");

        if (variable.Type != Variable.TypeEnum.Selector)
          throw new Exception($"The DataAggregator can only build cubes with selector variables, but {variable.Description} is of type {variable.Type}");
      }
      
      List<Dimension> dimensions = BuildDimensions(variableNames);
      List<Measure> measures = BuildMeasures(query.Selection.TableName);

      CubesService cubesService = new CubesService(connectorFactory, dataViewName);
      List<string> rows = await cubesService.CalculateCube(systemName, sessionDetails, query, dimensions, measures, TimeSpan.FromMinutes(5));
      if (rows == null)
        return false;

      foreach (string row in rows)
      {
        outputWriter.WriteLine(row);
      }

      return true;
    }
    #endregion

    #region private methods
    private List<Dimension> BuildDimensions(List<string> variableNames)
    {
      return variableNames.Select((n, i) => new Dimension(
        Id: $"Dimension_{i}",
        Type: Dimension.TypeEnum.Selector,
        VariableName: n,
        Query: null)).ToList();
    }

    private List<Measure> BuildMeasures(string resolveTableName)
    {
      Measure countMeasure = new Measure(
        Id: "count",
        ResolveTableName: resolveTableName,
        Function: Measure.FunctionEnum.Count);

      return new List<Measure>() { countMeasure };
    }
    #endregion
  }
}
