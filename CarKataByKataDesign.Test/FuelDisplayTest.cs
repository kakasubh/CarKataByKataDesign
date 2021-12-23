using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Moq;
using Xunit;

namespace CarKataByKataDesign.Test
{
    public class FuelDisplayTest
    {
        Mock<ICar> mockCar = new Mock<ICar>();
        Mock<Fuel> mockFuel = new Mock<Fuel>();

        [Fact]
        public void FuelDetails_Test()
        {
            FuelDisplay fuelDisplay = new FuelDisplay(mockCar.Object, mockFuel.Object);

            //There is no logic in the display method hence there will not be any exceptions.
            fuelDisplay.FuelDetails();
        }
    }
}
