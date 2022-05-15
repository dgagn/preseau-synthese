using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Synthese.Models;

public class NetworkCard
{
  private readonly NetworkInterface _networkInterface;

  public NetworkCard(NetworkInterface networkInterface)
  {
    _networkInterface = networkInterface;
    MAC = networkInterface.GetPhysicalAddress().ToString();
  }

  public string IPv4
  {
    get
    {
      var adressesIPv4 = _networkInterface.GetIPProperties().UnicastAddresses
        .Where(uni => uni.Address.AddressFamily == AddressFamily.InterNetwork).ToList();
      return adressesIPv4.Count == 0 ? "N/D" : adressesIPv4[0].Address.ToString();
    }
  }

  public string MAC { get; }

  [ReadOnly(true)]
  [DisplayName("Fabriquant")]
  public string Maker { get; set; } = "";


  [ReadOnly(true)]
  [Category("Info")]
  [DisplayName("Nom")]
  public string CardName => _networkInterface.Name;

  public string Description => _networkInterface.Description;

  public string Type => (int) _networkInterface.NetworkInterfaceType == 53
    ? "Virtuel"
    : _networkInterface.NetworkInterfaceType.ToString();
}