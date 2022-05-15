using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;
using ServerExer;

namespace Synthese.Services;

public interface IBroadcasterService
{
  List<(IPAddress, UdpClient)> GetAllClientsForBroadcast(ushort port);
  void BroadcastMessage(List<(IPAddress, UdpClient)> clients, string message);
}

public class BroadcasterService : IBroadcasterService
{
  private readonly ILogger<BroadcasterService> _logger;

  public BroadcasterService(ILogger<BroadcasterService> logger)
  {
    _logger = logger;
  }

  public List<(IPAddress, UdpClient)> GetAllClientsForBroadcast(ushort port)
  {
    var clients = new List<(IPAddress, UdpClient)>();

    foreach (var nic in NetworkInterface.GetAllNetworkInterfaces()
               .ToList().FindAll(n => n.OperationalStatus == OperationalStatus.Up))
    {
      var ip = nic.GetIPProperties().UnicastAddresses
        .First(u => u.Address.AddressFamily == AddressFamily.InterNetwork);
      var u = new UdpClient(new IPEndPoint(ip.Address, 0));
      try
      {
        u.Connect(new IPEndPoint(IPAddress.Broadcast, port));
        clients.Add((ip.Address, u));
      }
      catch (SocketException)
      {
        _logger.LogError(
          $"Impossible de préparer un socket pour l'interface avec l'ip {ip.Address} vers le port {port}.");
      }
    }

    return clients;
  }

  public void BroadcastMessage(List<(IPAddress, UdpClient)> clients, string message)
  {
    foreach (var (ip, client) in clients)
    {
      client.EnvoyerMessage(message);
      var remote = client.Client.RemoteEndPoint?.ToString()?.Split(':');
      var strPort = remote.Length == 2 ? remote[1] : "0";
      var isValidPort = int.TryParse(strPort, out var port);
      if (!isValidPort) return;
      _logger.LogInformation($"{message} à été diffusé sur {ip} avec le port {port}.");
    }
  }
}