using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class CarDashboard: ICarDashboard
    {
        public void Display()
        {
            Console.WriteLine("Enter any of the following values.");

            Console.WriteLine("1. Start Car");


            Console.WriteLine("2. Stop Car");

            Console.WriteLine("3. Brake Car");

            Console.WriteLine("4. Accelerate Car");

            Console.WriteLine("5. Refuel"); 
        }
    }
}
