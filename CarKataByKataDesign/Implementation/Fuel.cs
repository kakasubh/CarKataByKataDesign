using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Fuel: IFuel
    {
        private  double _currentFuel = 20;
        private bool _isReserve = false;

        

        public double CurrentFuel
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
                return _isReserve;
            }
        }

        public double GetFuelDetails()
        {
            return CurrentFuel;
        }

        public void Reserve()
        {
            _isReserve = true;
        }

        public void ReFuel(int fuel)
        {
            try
            {
                if (CurrentFuel + fuel > 60)
                {
                    Console.WriteLine(
                        $"Maximum capacity is 60 liters. Current volume is already {CurrentFuel}. Please enter the valid input.");
                    return;
                }

                if (CurrentFuel > 60)
                {
                    Console.WriteLine("Maximum capacity of 60 liters reached");
                }


                _currentFuel += fuel;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public void ConsumeFuel(double value)
        {
            _currentFuel -= value;
        }
    }
}
