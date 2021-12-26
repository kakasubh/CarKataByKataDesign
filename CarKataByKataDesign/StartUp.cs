using System;
using CarKataByKataDesign.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace CarKataByKataDesign
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
                var services = new ServiceCollection();

                // Resolving dependent classes against their contracts using dependency injection of microsoft extensions

                services.AddTransient<EntryPoint>();
                services.AddSingleton<ICar, Car>();
                services.AddSingleton<ICar, Car>();
                services.AddSingleton<IFuel, Fuel>();
                services.AddSingleton<IEngine, Engine>();
                services.AddSingleton<IDriving, Driving>();

                return services;
            }

    }
}