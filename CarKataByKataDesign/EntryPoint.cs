using System;
using CarKataByKataDesign.Contracts;

namespace CarKataByKataDesign
{
    public class EntryPoint
    {
        private readonly ICar _car;
        private readonly IDriving _driving;
        private readonly IFuel _fuel;
        

        // Constructor injections. Dependencies are resolved in startup class
        public EntryPoint(ICar car,  IDriving driving, IFuel fuel)
        {
            _car = car;
            _driving = driving;
            _fuel = fuel;
        }
        public void Run(String[] args)
        {
            do {
                        this.Display();

                    int option = Convert.ToInt16(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                _car.StartCar();
                                this.FuelDetails();
                                break;
                            }

                        case 2:
                            {
                                _car.StopCar();
                                this.FuelDetails();
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Enter the speed by which you would like to brake.");
                                var speed = Console.ReadLine();

                                if (!int.TryParse(speed, out int speedOutPut))
                                {
                                    Console.WriteLine($"{speed} is not a number");
                                    this.Display();
                                }
                                _driving.BrakeBy(speedOutPut);

                                this.FuelDetails();
                                break;

                            }
                        case 4:
                            {
                                Console.WriteLine("Enter the speed by which you would like to accelerate.");
                                var speed = Console.ReadLine();


                                if (!int.TryParse(speed, out int speedOutPut))
                                {
                                    Console.WriteLine($"{speed} is not a number");
                                    this.Display();
                                }
                                _driving.Accelerate(speedOutPut);

                                this.FuelDetails();
                                break;

                            }
                        case 5:
                            {
                                Console.WriteLine("How much fuel would you like to refill?");
                                int fuelResponse = Convert.ToInt16(Console.ReadLine());
                                _fuel.ReFuel(fuelResponse);
                                this.FuelDetails();
                                break;

                            }
                        default:
                            {
                                Console.WriteLine("Please enter the only the value between 1 and 5.");

                                return;
                            }
                    } } while (1 == 1);

        }

        public void FuelDetails()
        {
            Double fuel = _fuel.GetFuelDetails();

            string fuelDisplay = $"{fuel:0.00}";
            Console.WriteLine("Current Fuel {0}, {1}", fuelDisplay, (_fuel.IsReserve) ? "is running in reserve" : "not in reserve");



            Console.WriteLine("Current Speed {0}", _car.GetCurrentSpeed());

            Console.WriteLine("Current Temperature {0}", _car.GetTemperature());
            Console.WriteLine();
            Console.WriteLine();
        }


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