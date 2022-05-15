using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Synthese.Services;

public interface ITracerouteService
{
  Task<List<IPAddress>> GetTraceRoute(string host, int ttl, int timeout);
}

public class TracerouteService : ITracerouteService
{
  private readonly ILogger<TracerouteService> _logger;

  public TracerouteService(ILogger<TracerouteService> logger)
  {
    _logger = logger;
  }

  public async Task<List<IPAddress>> GetTraceRoute(string host, int ttl, int timeout)
  {
    _logger.LogInformation($"Ttl : {ttl}");
    var p = new Ping();
    var options = new PingOptions(ttl, true);
    var buffer = Encoding.ASCII.GetBytes("AAAAAAAAAAAA");

    var reply = await p.SendPingAsync(host, timeout, buffer, options);

    var res = new List<IPAddress>();

    switch (reply)
    {
      case {Status: IPStatus.Success}:
        res.Add(reply.Address);
        break;
      case {Status: IPStatus.TtlExpired or IPStatus.TimedOut}:
      {
        if (reply.Status == IPStatus.TtlExpired) res.Add(reply.Address);
        res.AddRange(await GetTraceRoute(host, ttl + 1, timeout));
        break;
      }
      default:
        _logger.LogError("Une erreur c'est produite dans le traceroute.");
        break;
    }

    return res;
  }
}