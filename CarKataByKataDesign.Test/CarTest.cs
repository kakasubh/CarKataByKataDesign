using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Moq;
using Xunit;

namespace CarKataByKataDesign.Test
{
 

    public class CarTest
    {
        Mock<IDriving> mockDriving = new Mock<IDriving>();
        Mock<IFuel> mockFuel = new Mock<IFuel>();

        Mock<IEngine> mockEngine = new Mock<IEngine>();

        [Theory]
        [InlineData(10, true)]
        [InlineData(0, false)]
        public void StartCar_Test(int fuelLevel, bool isRunning)
        {
            //Arrange
            mockFuel.SetupGet(x => x.CurrentFuel).Returns(fuelLevel);

            //Act
            Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
            car.StartCar();

            //Assert
            Assert.Equal(isRunning, car.IsRunning);
        }
       
       
        [Fact]
        public void GetCurrentTemperature_Test()
        {
            // Arrange
            int expectedTemperature = 30;

            // Act
            Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
            int result =  car.GetTemperature();
            // Assert
            Assert.Equal(expectedTemperature, result);


        }

        [Fact]
        public void StopCar_Test()
        {
            //Arrange
            bool expected = false;

            //Act
            Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
            car.StopCar();
            

            //Assert
            Assert.Equal(expected, car.IsRunning);

        }

        [Fact]
        public void StopCar_Negative_Test()
        {
            //Arrange
            bool expected = true;

            //Act
            Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
            car.StopCar();


            //Assert
            Assert.NotEqual(expected, car.IsRunning);
        }


        [Theory]
        [InlineData(30,30)]
        [InlineData(50, 50)]

        public void GetCurrentSpeed_Test(int expectedSpeed, int actualSpeed)

        {
            
            // Act
            mockDriving.Setup(x => x.LiveSpeed).Returns(expectedSpeed);
            
            // Assert
            Assert.Equal(expectedSpeed, actualSpeed);
        }
    }
}
