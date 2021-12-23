using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Fuel: IFuel
    {
        private  double _currentFuel = 20;
        private bool _IsReserve = false;

        

        public double currentFuel
        {
            get
            {
                return _currentFuel;
            }
        }

        public bool IsReserve
        {
            get
            {
                return _IsReserve;
            }
        }

        public double GetFuelDetails()
        {
            return currentFuel;
        }

        public void Reserve()
        {
            _IsReserve = true;
        }

        public void ReFuel(int fuel)
        {
            if (currentFuel + fuel > 60)
            {
                Console.WriteLine("Maximum capacity is 60 liters. Current volume is already {0}. Please enter the valid input.", currentFuel);
                return;
            }

            if (currentFuel > 60)
            {
                Console.WriteLine("Maximum capacity of 60 liters reached");

            }


            _currentFuel += fuel;
        }

        public void ConsumeFuel(double value)
        {
            _currentFuel -= value;
            Math.Round(_currentFuel, 10);
        }
    }
}
