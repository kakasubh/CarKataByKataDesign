using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Xunit;

namespace CarKataByKataDesign.Test
{
    // This is a simple Console display class
    public class CarDashboardTest
    {
        [Fact]
        public void CarDashboard_Test()
        {
            CarDashboard carDashboard = new CarDashboard();

            //There is no logic in the display method hence there will not be any exceptions.
            carDashboard.Display();
        }
    }
}
