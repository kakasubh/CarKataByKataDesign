using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Car : ICar
    {
        public IDriving Driving;
        public IFuel Fuel;
        public IEngine Engine;
        public  int CurrentTemperature = 30;
        private bool _isRunning = false;

        public Car(IDriving driving, IFuel fuel, IEngine engine)
        {
            Driving = driving;
            Fuel = fuel;
            Engine = engine;
        }
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
        }

        public int GetCurrentSpeed()
        {
            
            return Driving.LiveSpeed;
        }

        public int GetTemperature()
        {
            return CurrentTemperature;
        }

        public void StartCar()
        {
            
            if (_isRunning == true)
            {
                Console.WriteLine("Engine is already running. Please press any other option to proceed.");
                return;
            }
            if (Fuel.CurrentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;
            }
            _isRunning = true;
            Engine.StartEngine();
            Console.WriteLine("Engine started.");
            

            if (Fuel.CurrentFuel <= 5)
            {
                Fuel.Reserve();
            }

            return;

        }

        public void StopCar()
        {
            if (_isRunning == false)
            {
                Console.WriteLine("Engine is not running. Please execute again and select option 1 to start the engine");
                return;
            }

            _isRunning = false;
            Driving.Stop();
            Engine.StopEngine();
            

            Console.WriteLine("Car is stopped.");
        }
    }
}
