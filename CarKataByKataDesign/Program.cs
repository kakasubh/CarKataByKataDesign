using System;
using Microsoft.Extensions.DependencyInjection;
namespace CarKataByKataDesign
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var services = Startup.ConfigureServices();
                var serviceProvider = services.BuildServiceProvider();

                // Below call will Run method of EntryPoint class to make subsequent calls into the application
                serviceProvider.GetService<EntryPoint>().Run(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
