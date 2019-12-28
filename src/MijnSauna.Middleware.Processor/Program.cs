using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MijnSauna.Middleware.Processor.DependencyInjection;
using MijnSauna.Middleware.Processor.Workers;

namespace MijnSauna.Middleware.Processor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSystemd()
                .ConfigureServices((hostContext, services) =>
                {
                    services.ConfigureProcessor();
                    services.AddHostedService<SessionWorker>();
                    services.AddHostedService<SampleWorker>();
                });
    }
}