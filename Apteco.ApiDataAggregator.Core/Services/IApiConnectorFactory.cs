using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public interface IApiConnectorFactory
  {
    #region public methods
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails);
    ICubesApi CreateCubesApi(SessionDetails sessionDetails);
    IQueriesApi CreateQueriesApi(SessionDetails sessionDetails);
    #endregion
  }
}
