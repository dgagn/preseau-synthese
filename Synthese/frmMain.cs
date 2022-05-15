using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Extensions.Logging;
using Synthese.Models;
using Synthese.Services;

namespace Synthese;

/**
 * Ultimement, j'aimerais créer plusieurs control winforms. Cependant, j'obtenais
 * une erreur MessageBox rouge à chaque fois que je voulais me créer des controls
 * personnel. Donc, désolé pour la grosse classe de form main. Aussi, c'est un peu
 * moins pire avec l'injection de dépendance. On peut changer le comportement de n'importe
 * quel service, tant que le service implémente l'interface.
 *
 * @author Dany Gagnon
 */
public partial class FrmMain : Form
{
  private readonly IBroadcasterService _broadcaster;
  private readonly IEmailService _email;
  private readonly ILogger<FrmMain> _logger;
  private readonly IMacVendorService _macVendor;
  private readonly IPortService _ports;
  private readonly IPortScannerService _portScanner;
  private readonly ITracerouteService _traceroute;

  private bool _shouldBroadcast;
  private bool _shouldFetchMail;
  private bool _shouldPing;
  private bool _shouldPortScan;
  private bool _shouldTraceroute;

  public FrmMain(ILogger<FrmMain> logger, IPortService ports, IPortScannerService portScanner,
    IBroadcasterService broadcaster, IEmailService email, ITracerouteService traceroute,
    IMacVendorService macVendor)
  {
    InitializeComponent();
    _logger = logger;
    _ports = ports;
    _portScanner = portScanner;
    _broadcaster = broadcaster;
    _email = email;
    _traceroute = traceroute;
    _macVendor = macVendor;
  }

  private async void FrmMain_Load(object sender, EventArgs e)
  {
    var cards = NetworkInterface.GetAllNetworkInterfaces()
      .Select(nic => new NetworkCard(nic))
      .ToList();
    dgvInterfaces.Invoke(() => dgvInterfaces.DataSource = cards);

    var tasks = cards.Select(_macVendor.GetMacVendors).ToList();
    var newCards = await Task.WhenAll(tasks);
    try
    {
      if (newCards.Length > 0) dgvInterfaces.Invoke(() => dgvInterfaces.DataSource = newCards);
    }
    catch (Exception exception)
    {
      _logger.LogError($"Une erreur c'est produite avec le binding des nouvelles cartes réseaux. {exception.Message}");
    }
  }

  private void btnPortScan_Click(object sender, EventArgs e)
  {
    if (_shouldPortScan) return;

    var isValid = IPAddress.TryParse(txtAddress.Text, out var ipAddress);
    if (!isValid)
    {
      lblInvalidAddress.Text = "Adresse IP est invalide.";
      return;
    }

    lblInvalidAddress.Text = "";

    dgvPortScanner.Invoke(() => dgvPortScanner.DataSource = null);

    async void ScanPorts()
    {
      _shouldPortScan = true;
      btnPortScan.Loading();
      var openPorts = await _portScanner.ScanOpenPorts(ipAddress!);
      dgvPortScanner.Invoke(() => dgvPortScanner.DataSource = _ports.GetPopularPorts()
        .Select(p => new PortScan {Port = p, Status = openPorts.Any(open => open == p) ? "Ouvert" : "Fermé"})
        .OrderByDescending(p => p.Status)
        .ToList());
      btnPortScan.Reset();
      _shouldPortScan = false;
    }

    new Task(ScanPorts).Start();
  }

  private void btnBroadcast_Click(object sender, EventArgs e)
  {
    if (_shouldBroadcast)
    {
      _shouldBroadcast = false;
      txtPort.Enabled = true;
      btnBroadcast.Reset();
      _logger.LogInformation("Le diffuseur est arrêté.");
      return;
    }

    var isPortValid = int.TryParse(txtPort.Text, out var port);

    if (!isPortValid)
    {
      lblInvalidPort.Text = "Port invalide.";
      return;
    }

    lblInvalidPort.Text = "";

    _shouldBroadcast = true;
    btnBroadcast.Loading();
    txtPort.Enabled = false;
    var clientName = lblInterfaceDiffusion.Text ?? "";

    async void Broadcast()
    {
      var clients = _broadcaster.GetAllClientsForBroadcast((ushort) port);

      if (!string.IsNullOrEmpty(clientName))
        clients = clients.Where(tuple => tuple.Item1.ToString() == clientName).ToList();

      while (_shouldBroadcast)
      {
        rtbMessage.Invoke(() => _broadcaster.BroadcastMessage(clients!, rtbMessage.Text));
        await Task.Delay(2000);
      }
    }

    new Task(Broadcast).Start();
  }

  private void btnMail_Click(object sender, EventArgs e)
  {
    if (_shouldFetchMail) return;

    async void GetMails()
    {
      List<Email> emails = new();
      _shouldFetchMail = true;
      var connection = new EmailConnectionBuilder()
        .WithUsername(txtUsername.Text)
        .WithPassword(txtPassword.Text)
        .WithPort((ushort) int.Parse(txtMailPort.Text))
        .WithServer(txtServer.Text)
        .Build();

      btnMail.Loading();
      var mails = await _email.GetEmails(connection);
      emails.AddRange(mails);
      dgvMails.Invoke(() => dgvMails.DataSource = emails);
      btnMail.Reset();
      _shouldFetchMail = false;
    }

    new Task(GetMails).Start();
  }

  private void btnPing_Click(object sender, EventArgs e)
  {
    if (_shouldPing)
    {
      _shouldPing = false;
      btnPing.Reset();
      _logger.LogInformation("Le ping est arrêté.");
      txtTimeout.Enabled = true;
      return;
    }

    _shouldPing = true;
    btnPing.Loading();

    var validTimeout = int.TryParse(txtTimeout.Text, out var timeout);

    if (!validTimeout)
    {
      _logger.LogError("Le timeout est invalide.");
      return;
    }

    txtTimeout.Enabled = false;

    async void Ping()
    {
      var p = new Ping();
      while (_shouldPing)
      {
        try
        {
          rtbICMP.Invoke(() =>
          {
            var lines = rtbICMP.Text.Split('\n');
            if (lines.Length > 50) rtbICMP.Text = string.Join('\n', lines.Skip(1));
          });
          var reply = await txtPingIpDns.Invoke(async () => await p.SendPingAsync(txtPingIpDns.Text, timeout));
          _logger.LogInformation("Envoi du ping");
          if (reply.Status == IPStatus.Success)
            rtbICMP.Invoke(() => rtbICMP.AppendText($"Succès {txtPingIpDns.Text} en {reply.RoundtripTime}ms.\n"));
          else
            rtbICMP.Invoke(() => rtbICMP.AppendText($"Erreur ping : {reply.Status}\n"));
        }
        catch (Exception exception)
        {
          _logger.LogError($"Erreur pour l'envoi du ping. {exception.Message}");
          break;
        }

        await Task.Delay(1000);
      }
    }

    new Task(Ping).Start();
  }

  private void btnTraceroute_Click(object sender, EventArgs e)
  {
    if (_shouldTraceroute) return;

    var validTimeout = int.TryParse(txtTimeout.Text, out var timeout);

    if (!validTimeout)
    {
      _logger.LogError("Le timeout est invalide.");
      return;
    }

    btnTraceroute.Loading();

    async void Traceroute()
    {
      var watch = new Stopwatch();
      watch.Start();
      _shouldTraceroute = true;
      var host = txtPingIpDns.Invoke(() => txtPingIpDns.Text);
      _logger.LogInformation($"Commencement du traceroute pour {host}.");
      var routes = await _traceroute.GetTraceRoute(host, 1, timeout);

      watch.Stop();

      var ms = watch.ElapsedMilliseconds;

      var enumerable = routes.SkipLast(1).Select((ip, index) => $"Noeud #{index} : Un noeud trouvé {ip}");
      var last = $"La destination final {routes.Last()} est atteinte en {ms} ms!";
      foreach (var ipAddress in enumerable)
      {
        rtbICMP.Invoke(() =>
        {
          var lines = rtbICMP.Text.Split('\n');
          if (lines.Length > 50) rtbICMP.Text = string.Join('\n', lines.Skip(1));
        });
        rtbICMP.Invoke(() => rtbICMP.AppendText(ipAddress + '\n'));
        _logger.LogInformation(ipAddress);
      }

      rtbICMP.Invoke(() => rtbICMP.AppendText(last + '\n'));
      _logger.LogInformation(last);
      btnTraceroute.Reset();
      _shouldTraceroute = false;
    }

    new Task(Traceroute).Start();
  }

  private void dgvInterfaces_DataError(object sender, DataGridViewDataErrorEventArgs e)
  {
    // rien
  }

  private void dgvInterfaces_SelectionChanged(object sender, EventArgs e)
  {
    if (dgvInterfaces.SelectedRows.Count == 0)
    {
      pgInterfaces.SelectedObject = null;
      return;
    }

    pgInterfaces.SelectedObject = dgvInterfaces.SelectedRows[0].DataBoundItem;
  }

  private void tsmPortScan_Click(object sender, EventArgs e)
  {
    if (dgvInterfaces.SelectedRows.Count == 0)
    {
      _logger.LogWarning("Rien de sélectionné, ne peux scanner sur rien :)");
      return;
    }

    var card = (dgvInterfaces.SelectedRows[0].DataBoundItem as NetworkCard)!;
    _logger.LogInformation($"Scan de port sur {card.IPv4}");
    tclDashboard.SelectedTab = tpPortScanner;
    txtAddress.Text = card.IPv4;
    btnPortScan.PerformClick();
  }

  private void tsmDiffusion_Click(object sender, EventArgs e)
  {
    if (dgvInterfaces.SelectedRows.Count == 0)
    {
      _logger.LogWarning("Rien de sélectionné, ne peux scanner sur rien :)");
      return;
    }

    var card = (dgvInterfaces.SelectedRows[0].DataBoundItem as NetworkCard)!;
    tclDashboard.SelectedTab = tpBroadcaster;
    lblInterfaceDiffusion.Text = card.IPv4;

    if (_shouldBroadcast) return;
    btnBroadcast.PerformClick();
  }

  private void tclDashboard_SelectedIndexChanged(object sender, EventArgs e)
  {
    lblInterfaceDiffusion.Text = "";
  }
}