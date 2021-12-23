using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public interface  ICar
    {
        bool IsRunning { get; }
        public int GetCurrentSpeed();
        public int GetTemperature();

        public void StartCar();

        public void StopCar();
    }
}
