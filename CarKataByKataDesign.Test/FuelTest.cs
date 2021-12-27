using CarKataByKataDesign.Contracts;
using FluentAssertions;
using Xunit;

namespace CarKataByKataDesign.Test
{
    public class FuelTest
    {
        readonly Fuel _fuel = new Fuel();

        [Theory]
        [InlineData(20, 40)]
        [InlineData(10, 30)]
        public void ReFuel_Test(int input, double expectedOutPut)
        {

            //Arrange
            _fuel.ReFuel(input);

            double result = _fuel.CurrentFuel;


            // Assert

            result.Should().Be(expectedOutPut);
        }
        [Fact]
        public void GetFuelDetails_Test()
        {
            //Arrange
            double expected = 20;

            //Act
            double result = _fuel.GetFuelDetails();

            //Assert

            Assert.Equal(expected, result);

        }

        [Fact]
        public void GetFuelDetails_Test_NegativeTest()
        {
            //Arrange
            double value = 10;

            //Act
            double result = _fuel.GetFuelDetails();

            //Assert

            Assert.NotEqual(value, result);

        }


        [Fact]
        public void Reserve_Test()
        {
            //Arrange
            bool expected = true;

            //Act
            _fuel.Reserve();

            bool result = _fuel.IsReserve;

            //Assert

            Assert.Equal(expected,result);
        }

        [Fact]
        public void Reserve_Test_NegativeTest()
        {
            //Arrange
            bool value = false;

            //Act
            _fuel.Reserve();

            bool result = _fuel.IsReserve;

            //Assert

            Assert.NotEqual(value, result);
        }
       

        [Fact]
        public void ReFuel_Test_NegativeTest()
        {
            //Arrange
            double value = 20;

            //Act
            _fuel.ReFuel(20);

            double result = _fuel.CurrentFuel;


            // Assert

            Assert.NotEqual(value, result);
        }

        [Fact]
        public void ConsumeFuel_Test()
        {
            //Act
            double expected = 10;

            //Act
            _fuel.ConsumeFuel(10);
            double result = _fuel.CurrentFuel;


            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConsumeFuel_Test_NegativeTest()
        {
            //Arrange
            double value = 15;

            //Act
            _fuel.ConsumeFuel(10);
            double result = _fuel.CurrentFuel;


            //Assert
            Assert.NotEqual(value, result);
        }
    }
}
