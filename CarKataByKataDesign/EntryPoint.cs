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
            //var carDashboard = new CarDashboard();
            //var fuelDisplay = new FuelDisplay();
            //var car = serviceProvider.GetService<ICar>();
            //var driving = new Driving();
            //var fuel = new Fuel();
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
                                _driving.BrakeBy(10);
                                _fuelDisplay.FuelDetails();
                                break;

                            }
                        case 4:
                            {
                                _driving.Accelerate(10);
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
                    Console.WriteLine("Strings and special characters are not allowed. Please enter integer between 1 and 5");
                }



            }
        }
    }
    
}