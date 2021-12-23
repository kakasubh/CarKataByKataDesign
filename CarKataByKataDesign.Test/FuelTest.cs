using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Xunit;

namespace CarKataByKataDesign.Test
{
    public class FuelTest
    {
        Fuel fuel = new Fuel();


        [Fact]
        public void GetFuelDetails_Test()
        {
            //Apply
            double expected = 20;

            //Act
            double result = fuel.GetFuelDetails();

            //Assert

            Assert.Equal(expected, result);

        }


        [Fact]
        public void Reserve_Test()
        {
            //Apply
            bool expected = true;

            //Act
            fuel.Reserve();

            bool result = fuel.IsReserve;

            //Assert

            Assert.Equal(expected,result);
        }

        [Fact]
        public void ReFuel_Test()
        {
            //Apply
            double expected = 40;

            //Act
            fuel.ReFuel(20);

            double result = fuel.currentFuel;


            // Assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConsumeFuel_Test()
        {
            //Act
            double expected = 10;

            //Act
            fuel.ConsumeFuel(10);
            double result = fuel.currentFuel;


            //Assert
            Assert.Equal(expected, result);
        }
    }
}
