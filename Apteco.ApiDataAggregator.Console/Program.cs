using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiDataAggregator.ApiClient.Model;
using Apteco.ApiDataAggregator.Core;
using Apteco.ApiDataAggregator.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiDataAggregator.Console
{
  class Program
  {
    private static int Main(string[] args)
    {
      if (args == null || args.Length < 1)
      {
        return OutputUsage();
      }

      Task<int> task = Task.Run(() => PerformAction(args));
      task.Wait();
      return task.Result;
    }

    private static async Task<int> PerformAction(string[] args)
    {
      if (args.Length < 7)
        return OutputUsage();

      List<string> variableNames = args.Skip(6).Select(s => s.Trim()).ToList();
      return await OutputCube(args[0], args[1], args[2], args[3], args[4], args[5], variableNames);
    }

    private static int OutputUsage()
    {
      string usageString =
        "Usage: " + Environment.NewLine +
        "  ApiDataAggregator-Console.exe <Orbit API base URL> <DataView name> <username> <password> <system name> <query file path> <variable name 1> [<varable name 2> ...]" + Environment.NewLine +
        Environment.NewLine +
        Environment.NewLine +
        "This will output a cube for the records selected by the given query, for each of the specified variable dimensions." + Environment.NewLine +
        "Note that the variables specified must be selector variables." + Environment.NewLine;

      System.Console.WriteLine(usageString);
      return 0;
    }

    private static async Task<int> OutputCube(string baseUrl, string dataViewName, string username, string password, string systemName, string queryFilePath, List<string> variableNames)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();

        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);
        LoginService loginService = new LoginService(connectorFactory, dataViewName);

        SessionDetails sessionDetails = await loginService.Login(username, password);
        if (sessionDetails == null)
        {
          logger.LogError($"Couldn't log in to data view {dataViewName} as user {username}");
          return -1;
        }

        try
        {
          DataAggregator dataExplorer = new DataAggregator(connectorFactory, dataViewName, loggingHandler.CreateLogger<DataAggregator>());
          bool success = await dataExplorer.TryShowCubeForVariables(sessionDetails, systemName, queryFilePath, variableNames, System.Console.Out);
          return success ? 0 : -1;
        }
        finally
        {
          await loginService.Logout(sessionDetails);
        }
      }
    }
  }
}
