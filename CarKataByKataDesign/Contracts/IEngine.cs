using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public interface IEngine
    {
        public bool IsEngineRunning { get; }

        public void StartEngine();

        public void StopEngine();
    }
}
