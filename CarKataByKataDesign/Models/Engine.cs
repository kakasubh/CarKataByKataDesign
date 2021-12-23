using System;
using System.Collections.Generic;
using System.Text;

namespace CarKataByKataDesign.Contracts
{
    public  class Engine: IEngine
    {
        public bool _IsEngineRunning = false;

        public bool IsEngineRunning
        {
            get
            {
                return _IsEngineRunning;
            }
        }

        public void StartEngine()
        {
            _IsEngineRunning = true;
        }

        public void StopEngine()
        {
            _IsEngineRunning = false;
        }
    }
}
