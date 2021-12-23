using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class FuelDisplay: IFuelDisplay
    {

        public ICar _car;
        public IFuel _fuel;

        public FuelDisplay(ICar car, IFuel fuel)
        {
            _car = car;
            _fuel = fuel;
        }
        public void FuelDetails()
        {
           
            Console.WriteLine("Current Fuel {0}, {1}", Math.Round(_fuel.GetFuelDetails(), 2), (_fuel.IsReserve) ? "is running in reserve" : "not in reserve");


            Console.WriteLine("Current Speed {0}", _car.GetCurrentSpeed());

            Console.WriteLine("Current Temperature {0}", _car.GetTemperature());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
