using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Car : ICar
    {
        public IDriving _driving;
        public IFuel _fuel;
        public IEngine _engine;
        public  int CurrentTemperature = 30;
        private bool _IsRunning = false;

        public Car(IDriving driving, IFuel fuel, IEngine engine)
        {
            _driving = driving;
            _fuel = fuel;
            _engine = engine;
        }
        public bool IsRunning
        {
            get
            {
                return _IsRunning;
            }
        }

        public int GetCurrentSpeed()
        {
            
            return _driving.LiveSpeed;
        }

        public int GetTemperature()
        {
            return CurrentTemperature;
        }

        public void StartCar()
        {
            
            if (_IsRunning == true)
            {
                Console.WriteLine("Engine is already running. Please press any other option to proceed.");
                return;
            }
            if (_fuel.currentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;
            }
            _IsRunning = true;
            _engine.StartEngine();
            Console.WriteLine("Engine started.");
            

            if (_fuel.currentFuel <= 5)
            {
                _fuel.Reserve();
            }

            return;

        }

        public void StopCar()
        {
            if (_IsRunning == false)
            {
                Console.WriteLine("Engine is not running. Please execute again and select option 1 to start the engine");
                return;
            }

            _IsRunning = false;
            _driving.Stop();
            _engine.StopEngine();
            

            Console.WriteLine("Car is stopped.");
        }
    }
}
