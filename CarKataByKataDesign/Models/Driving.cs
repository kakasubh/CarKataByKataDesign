using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Driving: IDriving
    {
        private int _LiveSpeed = 20;
        //private ICar _car;
        private IFuel _fuel;
        private IEngine _engine;

        public Driving(IEngine engine, IFuel fuel)
        {
            _engine = engine;
            _fuel = fuel;
        }

        public int LiveSpeed
        {
            get
            {
                return _LiveSpeed;
            }
        }

        public void BrakeBy(int Speed)
        {
            if (_fuel.currentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;

            }
            if (_engine.IsEngineRunning)
            {
                if (Speed < LiveSpeed)
                {
                    _LiveSpeed = LiveSpeed - Speed;
                }
            }

            if (LiveSpeed == 0 && _engine.IsEngineRunning)
            {
                _fuel.ConsumeFuel(-0.12);
            }
            if (LiveSpeed <= 60)
            {
                _fuel.ConsumeFuel(0.0020);

            }

            if (LiveSpeed >= 61 && LiveSpeed <= 100)
            {
                _fuel.ConsumeFuel(0.0014);

            }

            if (LiveSpeed >= 101 && LiveSpeed <= 140)
            {
                _fuel.ConsumeFuel(0.0020);

            }

            if (LiveSpeed >= 141 && LiveSpeed <= 200)
            {
                _fuel.ConsumeFuel(0.0025);

            }

            if (LiveSpeed >= 201 && LiveSpeed <= 250)
            {
                _fuel.ConsumeFuel(0.0030);

            }

           
        }

        public void Stop()
        {
            _LiveSpeed = 0;
        }

        public void Accelerate(int Speed = 10)
        {

            if (_fuel.currentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;

            }

            if (_engine.IsEngineRunning == false)
            {
                Console.WriteLine("Engine is not running. Please execute again and select option 1 to start the engine and select 4 to accelerate.");
                return;
            }
            if (_fuel.currentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;

            }
           

            if (_engine.IsEngineRunning)
            {
                _LiveSpeed = LiveSpeed + Speed;
            }

            if (LiveSpeed >= 250)
            {
                Console.WriteLine("Speed of car cannot be more than 250.");
                return;
            }

            if (LiveSpeed <= 60)
            {
                _fuel.ConsumeFuel(0.0020);
            }

            if (LiveSpeed >= 61 && LiveSpeed <= 100)
            {
                _fuel.ConsumeFuel(0.0014);
            }

            if (LiveSpeed >= 101 && LiveSpeed <= 140)
            {
                _fuel.ConsumeFuel(0.0020);
            }

            if (LiveSpeed >= 141 && LiveSpeed <= 200)
            {
                _fuel.ConsumeFuel(0.0025);
            }

            if (LiveSpeed >= 201 && LiveSpeed <= 250)
            {
                _fuel.ConsumeFuel(0.0030);
            }
        }
    }
}
