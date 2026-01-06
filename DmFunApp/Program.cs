using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DmFunApp
{
    internal class Program()
    {
        static void Main()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            RegisterServices(builder.Services);

            using IHost host = builder.Build();

            host.Services.GetService<IApp>()!.Run();
        }

        static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IApp, App>();
            services.AddTransient<INumberProvider, NumberProvider>();
            services.AddTransient<ICalculator, Calculator>();
        }
    }
}
