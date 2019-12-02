using System;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public class QueriesService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public QueriesService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<Query> GetQueryDefinitionFromFile(string systemName, SessionDetails sessionDetails, string filePath, TimeSpan timeout)
    {
      if (filePath == null)
        throw new ArgumentNullException(nameof(filePath));

      IQueriesApi queriesApi = connectorFactory.CreateQueriesApi(sessionDetails);

      QueryResult queryResult = await queriesApi.QueriesPerformGetQueryFileDefinitionSynchronouslyAsync(dataViewName, systemName, new QueryFile(filePath));
      return queryResult?.Query;
    }
    #endregion
  }
}
