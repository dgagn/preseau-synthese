using System.Net;
using System.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using Synthese.Models;

namespace Synthese.Services;

public interface IMacVendorService
{
  Task<NetworkCard> GetMacVendors(NetworkCard c);
}

public class MacVendorService : IMacVendorService
{
  private readonly ILogger<MacVendorService> _logger;
  private readonly SemaphoreSlim _throttler = new(1);

  public MacVendorService(ILogger<MacVendorService> logger)
  {
    _logger = logger;
  }

  public async Task<NetworkCard> GetMacVendors(NetworkCard c)
  {
    var client = new HttpClient {BaseAddress = new Uri("http://api.macvendors.com/")};
    // Devrait cacher le token dans .env, mais c'est juste vous qui avez accès à mon projet.
    client.DefaultRequestHeaders.Authorization =
      new AuthenticationHeaderValue("Bearer",
        "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImp0aSI6ImUyNGVjODJmLWYwZjctNDBjYS1iNWViLTRlMTAxNjU3MDAzNCJ9.eyJpc3MiOiJtYWN2ZW5kb3JzIiwiYXVkIjoibWFjdmVuZG9ycyIsImp0aSI6ImUyNGVjODJmLWYwZjctNDBjYS1iNWViLTRlMTAxNjU3MDAzNCIsImlhdCI6MTY1MjY0MDk3MywiZXhwIjoxOTY3MTM2OTczLCJzdWIiOiI5ODYzIiwidHlwIjoiYWNjZXNzIn0.E4JvcOa4Fw-CCX1mqnLCZoWuFAnxWp0Z6igjzGci3xjeS3CmbjA7VmJ5Tcz77v3kguaxV46iESrD9-6u-LnEeA");
    await _throttler.WaitAsync();
    try
    {
      if (string.IsNullOrEmpty(c.MAC)) return c;
      _logger.LogInformation($"Commence la requête pour trouver le vendor de {c.CardName}");
      var res = await client.GetAsync(c.MAC);
      await Task.Delay(1000);

      _logger.LogInformation($"Status de la requête : {res.StatusCode}");

      if (res.IsSuccessStatusCode)
      {
        c.Maker = await res.Content.ReadAsStringAsync();
        return c;
      }

      if (res.StatusCode == HttpStatusCode.TooManyRequests)
      {
        _logger.LogInformation($"On attend pour relancer la requête car too many request {c.CardName}.");
        await Task.Delay(2000);
        return await GetMacVendors(c);
      }

      c.Maker = "N/D";
      return c;
    }
    finally
    {
      _throttler.Release();
    }
  }
}