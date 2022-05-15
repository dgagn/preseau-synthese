namespace Synthese.Services;

public interface IPortService
{
  List<ushort> GetPopularPorts();
}

public class PortService : IPortService
{
  public List<ushort> GetPopularPorts()
  {
    var ports = new List<ushort> {21, 22, 80, 110, 111, 139, 3306};
    return ports;
  }
}