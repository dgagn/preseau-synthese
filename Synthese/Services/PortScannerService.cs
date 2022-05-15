using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;

namespace Synthese.Services;

public interface IPortScannerService
{
  Task<List<ushort>> ScanOpenPorts(IPAddress address);
}

public class PortScannerServiceService : IPortScannerService
{
  private readonly ILogger<PortScannerServiceService> _logger;
  private readonly List<ushort> _openPorts = new();
  private readonly List<ushort> _ports;

  public PortScannerServiceService(IPortService service, ILogger<PortScannerServiceService> logger)
  {
    _ports = service.GetPopularPorts();
    _logger = logger;
  }

  public async Task<List<ushort>> ScanOpenPorts(IPAddress address)
  {
    _openPorts.Clear();
    var tasks = _ports.Select(p => ScanPortForAddressAsync(address, p));
    _logger.LogInformation($"Le scan de port commence sur l'adresse {address} pour les {_ports.Count} ports.");
    await Task.WhenAll(tasks);
    _logger.LogInformation(
      $"Le scan de port est terminé. Il y a {_openPorts.Count} ports d'ouvert sur l'adresse {address}");
    return _openPorts;
  }

  private async Task ScanPortForAddressAsync(IPAddress address, ushort port)
  {
    var cts = new CancellationTokenSource();
    cts.CancelAfter(1000);

    using TcpClient client = new();
    try
    {
      await client.ConnectAsync(address, port, cts.Token);
      _openPorts.Add(port);
    }
    catch
    {
      // fermé
    }
  }
}