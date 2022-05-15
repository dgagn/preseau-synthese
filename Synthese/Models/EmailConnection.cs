namespace Synthese.Models;

public class EmailConnection
{
  public string? Server { get; set; } = "";
  public ushort Port { get; set; }
  public string? Username { get; set; } = "";
  public string? Password { get; set; } = "";
}

public class EmailConnectionBuilder
{
  private readonly EmailConnection _connection = new();

  public EmailConnection Build()
  {
    return _connection;
  }

  public EmailConnectionBuilder WithServer(string server)
  {
    _connection.Server = server;
    return this;
  }

  public EmailConnectionBuilder WithPort(ushort port)
  {
    _connection.Port = port;
    return this;
  }

  public EmailConnectionBuilder WithUsername(string username)
  {
    _connection.Username = username;
    return this;
  }

  public EmailConnectionBuilder WithPassword(string password)
  {
    _connection.Password = password;
    return this;
  }
}