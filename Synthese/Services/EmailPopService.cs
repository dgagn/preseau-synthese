using System.Net.Security;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;
using ServerExer;
using Synthese.Models;

namespace Synthese.Services;

public interface IEmailService
{
  Task<List<Email>> GetEmails(EmailConnection connection);
}

public class EmailPopService : IEmailService
{
  private readonly ILogger<EmailPopService> _logger;
  private List<Email> _mails = new();

  public EmailPopService(ILogger<EmailPopService> logger)
  {
    _logger = logger;
  }

  public async Task<List<Email>> GetEmails(EmailConnection connection)
  {
    _mails = new List<Email>();
    var client = new TcpClient();

    var valid = await client.ConnecterTCPAsync(connection.Server ?? "", connection.Port);
    if (!valid)
    {
      _logger.LogError("Les paramètres de connection de sont pas valides.");
      return _mails;
    }

    var sll = new SslStream(client.GetStream());
    await sll.AuthenticateAsClientAsync(connection.Server ?? "");
    await sll.RecevoirMessageAsync(out var recv);
    _logger.LogInformation(recv.Trim());
    await sll.EnvoyerMessageAsync($"USER {connection.Username}");
    await sll.RecevoirMessageAsync(out recv);
    _logger.LogInformation(recv.Trim());
    await sll.EnvoyerMessageAsync($"PASS {connection.Password}");
    await sll.RecevoirMessageAsync(out recv);
    _logger.LogInformation(recv.Trim());

    if (!recv.Contains("Welcome"))
    {
      _logger.LogError("Les paramètres de connection de sont pas valides.");
      return _mails;
    }

    var enumerable = Enumerable.Range(1, 10)
      .Select(i => GetEmailAsync(i, sll))
      .ToList();

    await Task.WhenAll(enumerable);

    _logger.LogInformation($"{_mails.Count} courriels obtenus.");
    return _mails;
  }

  private async Task GetEmailAsync(int emailId, SslStream sll)
  {
    await sll.EnvoyerMessageAsync($"TOP {emailId} 100");
    var email = new EmailBuilder();

    await sll.RecevoirMessagesJusquaPointAsync(out var recv);

    var strings = recv.Split('\n')
      .Where(s => s.StartsWith("From:") || s.StartsWith("To:") || s.StartsWith("Subject:") ||
                  s.StartsWith("Date:"));

    foreach (var s in strings)
      if (s.StartsWith("From:")) email.WithFrom(s[5..].Trim());
      else if (s.StartsWith("To:")) email.WithTo(s[3..].Trim());
      else if (s.StartsWith("Subject:")) email.WithSubject(s[8..].Trim());
      else if (s.StartsWith("Date:")) email.WithDate(s[5..].Trim());
    _mails.Add(email.Build());
  }
}