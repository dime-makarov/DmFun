using Microsoft.Extensions.DependencyInjection;

namespace DmFunApp
{
    internal class Program()
    {
        static void Main()
        {
            var services = new ServiceCollection();

            RegisterServices(services);

            services.BuildServiceProvider().GetService<IApp>()!.Run();
        }

        static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IApp, App>();
            services.AddTransient<INumberProvider, NumberProvider>();
            services.AddTransient<ICalculator, Calculator>();
        }
    }
}
