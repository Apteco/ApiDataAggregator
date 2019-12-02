using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public class FastStatsSystemService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public FastStatsSystemService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<Variable> GetReferenceVariableForTable(SessionDetails sessionDetails, string systemName, string tableName)
    {
      IFastStatsSystemsApi systemApi = connectorFactory.CreateFastStatsSystemsApi(sessionDetails);

      string filter = $"(TableName eq '{tableName}') and (Type eq 'Reference')";
      PagedResultsVariable variables = await systemApi.FastStatsSystemsGetFastStatsVariablesAsync(dataViewName, systemName, filter, null, null, 1000000);
      if (variables.List.Count == 0)
      {
        return null;
      }

      return variables.List[0];
    }

    public async Task<Variable> GetVariable(SessionDetails sessionDetails, string systemName, string variableName)
    {
      IFastStatsSystemsApi systemApi = connectorFactory.CreateFastStatsSystemsApi(sessionDetails);

      return await systemApi.FastStatsSystemsGetFastStatsVariableAsync(dataViewName, systemName, variableName);
    }
    #endregion
  }
}
