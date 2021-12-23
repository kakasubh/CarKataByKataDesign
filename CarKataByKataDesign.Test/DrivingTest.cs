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
        Mock<IEngine> mockDriving = new Mock<IEngine>();
        Mock<IFuel> mockFuel = new Mock<IFuel>();

        [Fact]
        public void Accelerate_Test()
        {

            mockFuel.Setup(x => x.GetFuelDetails()).Returns(20);

            Driving driving = new Driving(mockDriving.Object, mockFuel.Object);

            driving.Accelerate();


        }

        [Fact]
        public void BrakeBy_Test()
        {

            mockFuel.Setup(x => x.GetFuelDetails()).Returns(20);

            Driving driving = new Driving(mockDriving.Object, mockFuel.Object);

            driving.Accelerate();


        }

        [Fact]
        public void Stop_Test()
        {
            mockFuel.Setup(x => x.GetFuelDetails()).Returns(20);

            Driving driving = new Driving(mockDriving.Object, mockFuel.Object);

            driving.Stop();

        }

    }
}
