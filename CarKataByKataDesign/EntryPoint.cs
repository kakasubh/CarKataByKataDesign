using System;
using CarKataByKataDesign.Contracts;

namespace CarKataByKataDesign
{
    public class EntryPoint
    {
        private readonly ICar _car;
        private readonly ICarDashboard _carDashboard;
        private readonly IDriving _driving;
        private readonly IFuel _fuel;
        private readonly IFuelDisplay _fuelDisplay;

        // Constructor injections. Dependecies are resolved in startup class
        public EntryPoint(ICar car, ICarDashboard carDashboard, IDriving driving, IFuelDisplay fuelDisplay, IFuel fuel)
        {
            _car = car;
            _carDashboard = carDashboard;
            _driving = driving;
            _fuel = fuel;
            _fuelDisplay = fuelDisplay;
        }
        public void Run(String[] args)
        {
            try
            {
                do
                {

                    _carDashboard.Display();

                    int option = Convert.ToInt16(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                _car.StartCar();
                                _fuelDisplay.FuelDetails();
                                break;
                            }

                        case 2:
                            {
                                _car.StopCar();
                                _fuelDisplay.FuelDetails();
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Enter the speed by which you would like to brake.");
                                var speed = Console.ReadLine();

                                if (int.TryParse(speed, out int speedOutPut))
                                {
                                    _driving.BrakeBy(speedOutPut);
                                }
                                else
                                {
                                    Console.WriteLine($"{speed} is not a number");
                                }
                               
                                _fuelDisplay.FuelDetails();
                                break;

                            }
                        case 4:
                            {
                                Console.WriteLine("Enter the speed by which you would like to accelerate.");
                                var speed = Console.ReadLine();

                                if (int.TryParse(speed, out int speedOutPut))
                                {
                                    _driving.Accelerate(speedOutPut);
                                }
                                else
                                {
                                    Console.WriteLine($"{speed} is not a number");
                                }
                               
                               
                                _fuelDisplay.FuelDetails();
                                break;

                            }
                        case 5:
                            {
                                Console.WriteLine("How much fuel to be refilled?");
                                int fuelResponse = Convert.ToInt16(Console.ReadLine());
                                _fuel.ReFuel(fuelResponse);
                                _fuelDisplay.FuelDetails();
                                break;

                            }
                        default:
                            {
                                Console.WriteLine("Please enter integer between 1 and 5.");

                                return;
                            }
                    }
                } while (1 == 1);

            }
            catch (Exception exception)
            {
                if (exception.Message == "Input string was not in a correct format.")
                {
                    Console.WriteLine("Strings and special characters are not allowed. Please enter only numbers from 1 to 5");
                }

                Console.WriteLine(exception.Message);

            }
        }
    }
    
}