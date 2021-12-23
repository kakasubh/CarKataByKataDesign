using System;
using CarKataByKataDesign.Contracts;
using Microsoft.Extensions.DependencyInjection;
namespace CarKataByKataDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serviceProvider = new ServiceCollection()
            //    .AddSingleton<ICar, Car>()
            //    .AddSingleton<IFuel, Fuel>()
            //    .AddSingleton<IEngine, Engine>()
            //    .AddSingleton<IDriving,Driving>()
            //    .AddSingleton<ICarDashboard, CarDashboard>()
            //    .AddSingleton<IFuelDisplay,FuelDisplay>()
            //    .BuildServiceProvider();

            var services = Startup.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<EntryPoint>().Run(args);

           
    }
    }
}
