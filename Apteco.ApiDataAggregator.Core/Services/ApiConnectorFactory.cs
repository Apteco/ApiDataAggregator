using System.Collections.Generic;
using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Client;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public class ApiConnectorFactory : IApiConnectorFactory
  {
    #region private fields
    private string baseUrl;
    #endregion

    #region public constructor
    public ApiConnectorFactory(string baseUrl)
    {
      this.baseUrl = baseUrl;
    }
    #endregion

    #region public methods
    public ISessionsApi CreateSessionsApi(SessionDetails sessionDetails)
    {
      return new SessionsApi(CreateConfiguration(sessionDetails));
    }

    public IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails)
    {
      return new FastStatsSystemsApi(CreateConfiguration(sessionDetails));
    }

    public ICubesApi CreateCubesApi(SessionDetails sessionDetails)
    {
      return new CubesApi(CreateConfiguration(sessionDetails));
    }

    public IQueriesApi CreateQueriesApi(SessionDetails sessionDetails)
    {
      return new QueriesApi(CreateConfiguration(sessionDetails));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = baseUrl
      };
    }
    #endregion
  }
}
