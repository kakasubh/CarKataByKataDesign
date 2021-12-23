using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public  interface  IDriving
    {
        int LiveSpeed { get; }
        public void BrakeBy(int Speed);

        public void Accelerate(int Speed);

        public void Stop();

    }
}
