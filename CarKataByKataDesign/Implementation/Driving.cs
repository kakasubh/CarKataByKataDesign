using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public class Driving: IDriving
    {
        //remove speed
        private int _liveSpeed =0;
        //private ICar _car;
        private readonly IFuel _fuel;
        private readonly IEngine _engine;

        public Driving(IEngine engine, IFuel fuel)
        {
            _engine = engine;
            _fuel = fuel;
        }

        public int LiveSpeed
        {
            get
            {
                return _liveSpeed;
            }
        }

        public void BrakeBy(int speed)
        {
            if (speed < 0)
            {
                Console.WriteLine("Speed input cannot be less than zero.");
                return;
            }
            if (speed > 10)
            {
                Console.WriteLine("The speed cannot be more that 10 kilometers per hour.");
                return;
            }

            if (_fuel.CurrentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;

            }
            if (_engine.IsEngineRunning)
            {
                if (speed < LiveSpeed)
                {
                    _liveSpeed = LiveSpeed - speed;
                }
                else
                {
                    _liveSpeed = 0;

                }
            }

            if (LiveSpeed == 0 && _engine.IsEngineRunning)
            {
                _fuel.ConsumeFuel(-0.0003);
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
            _liveSpeed = 0;
        }

        public void Accelerate(int speed)
        {
            if (speed < 0)
            {
                Console.WriteLine("Speed input cannot be less than zero.");
                return;
            }

            if (speed > 10)
            {
                Console.WriteLine("At a time speed cannot be increased by more than 10 kilometers per hour.");
                return;
            }

            if (_fuel.CurrentFuel <= 0)
            {
                Console.WriteLine("There is no fuel in the tank. Please hit enter and then press 5 to Refuel.");
                return;
            }

            if (_engine.IsEngineRunning == false)
            {
                Console.WriteLine("Engine is not running. Please execute again and select option 1 to start the engine and select 4 to accelerate.");
                return;
            }
           
           

            if (_engine.IsEngineRunning)
            {
                _liveSpeed = LiveSpeed + speed;
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
