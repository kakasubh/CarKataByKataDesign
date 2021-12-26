using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Moq;
using Xunit;

namespace CarKataByKataDesign.Test
{
    public class DrivingTest
    {
        Mock<IEngine> mockEngine = new Mock<IEngine>();
        Mock<IFuel> mockFuel = new Mock<IFuel>();


        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 10)]

        public void Accelerate_Test(int input, double result)
        {

            mockFuel.Setup(x => x.GetFuelDetails()).Returns(20);

            mockEngine.SetupGet(x => x.IsEngineRunning).Returns(true);

            mockFuel.SetupGet(x => x.CurrentFuel).Returns(20);

            Driving driving = new Driving(mockEngine.Object, mockFuel.Object);

            driving.Accelerate(input);

            Assert.Equal(result, driving.LiveSpeed);


        }

        [Fact]
        public void BrakeBy_Test()
        {

            mockEngine.SetupGet(x => x.IsEngineRunning).Returns(true);

            mockFuel.SetupGet(x => x.CurrentFuel).Returns(20);

            Driving driving = new Driving(mockEngine.Object, mockFuel.Object);

            driving.BrakeBy(10);


        }

        [Fact]
        public void Stop_Test()
        {
            //Arrange

            int expected = 0;

            mockFuel.SetupGet(x => x.CurrentFuel).Returns(0);

            Driving driving = new Driving(mockEngine.Object, mockFuel.Object);

            driving.Stop();

            Assert.Equal(expected, driving.LiveSpeed);

        }

    }
}
