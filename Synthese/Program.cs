using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.WinForms.Base;
using Synthese.Services;

namespace Synthese;

internal static class Program
{
  public static IServiceProvider? ServiceProvider { get; private set; }

  /// <summary>
  ///   The main entry point for the application.
  /// </summary>
  [STAThread]
  public static void Main()
  {
    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.

    Log.Logger = new LoggerConfiguration()
      .Enrich.FromLogContext()
      .WriteToSimpleAndRichTextBox()
      .CreateLogger();

    Application.SetHighDpiMode(HighDpiMode.SystemAware);
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    var host = CreateHostBuilder().Build();
    ServiceProvider = host.Services;

    ApplicationConfiguration.Initialize();
    Application.Run(ServiceProvider.GetRequiredService<FrmMain>());
  }

  private static IHostBuilder CreateHostBuilder()
  {
    return Host.CreateDefaultBuilder()
      .ConfigureServices((_, services) =>
      {
        services
          .AddTransient<IPortService, PortService>()
          .AddTransient<IPortScannerService, PortScannerServiceService>()
          .AddTransient<IBroadcasterService, BroadcasterService>()
          .AddTransient<IEmailService, EmailPopService>()
          .AddTransient<ITracerouteService, TracerouteService>()
          .AddTransient<IMacVendorService, MacVendorService>()
          .AddTransient<FrmMain>();
      })
      .UseSerilog();
  }
}