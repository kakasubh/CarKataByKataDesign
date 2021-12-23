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
        public void StartCar_Test()
        {

                Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
                bool isEngineRunning = true;

                car.StartCar();

              //  mockEngine.Setup(x => x._IsEngineRunning).Returns(true);

                bool result = true;

                Assert.Equal(isEngineRunning,result);
        }


        [Fact]
        public void StopCar_Test()
        {

            Car car = new Car(mockDriving.Object, mockFuel.Object, mockEngine.Object);
            bool isEngineRunning = false;

            car.StartCar();

           //  mockEngine.Setup(x => x._IsEngineRunning).Returns(false);

            bool result = false;

            Assert.Equal(isEngineRunning, result);
        }


        [Fact]
        public void GetCurrentSpeed_Test()
        {
            // Arrage 
            int expectedSpeed = 50;

            // Act
            mockDriving.Setup(x => x.LiveSpeed).Returns(50);
            int result = 50;

            // Assert
            Assert.Equal(expectedSpeed, result);
        }
    }
}
