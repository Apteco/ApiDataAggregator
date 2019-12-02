using System;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Api;
using Apteco.ApiDataAggregator.ApiClient.Model;

namespace Apteco.ApiDataAggregator.Core.Services
{
  public class LoginService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public LoginService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<SessionDetails> Login(string username, string password)
    {
      ISessionsApi sessionsApi = connectorFactory.CreateSessionsApi(null);
      SessionDetails details = await sessionsApi.SessionsCreateSessionSimpleAsync(dataViewName, username, password);
      if (details?.AccessToken == null)
        return null;

      return details;
    }

    public async Task Logout(SessionDetails sessionDetails)
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      ISessionsApi sessionsApi = connectorFactory.CreateSessionsApi(sessionDetails);
      await sessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
    }
    #endregion
  }
}
