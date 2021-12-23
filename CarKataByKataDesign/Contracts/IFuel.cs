using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public  interface IFuel
    {
        double currentFuel { get; }
        bool IsReserve { get; }
        public double GetFuelDetails();

        public void ReFuel(int fuel);

        public void Reserve();

        public void ConsumeFuel(double value);
    }
}
