using System;
using System.Collections.Generic;
using System.Text;
using CarKataByKataDesign.Contracts;
using Xunit;
using Xunit.Sdk;

namespace CarKataByKataDesign.Test
{
    public class EngineTest
    {
        private Engine engine = new Engine();

        [Fact]
        public void StartEngine_Test()
        {
            // Apply 

            bool expected = true;

            // Act

            engine.StartEngine();

            bool result = engine.IsEngineRunning;

            // Assert

            Assert.Equal(expected, result);


        }

        [Fact]
        public void StopEngine_Test()
        {
            // Apply 

            bool expected = false;

            // Act

            engine.StopEngine();

            bool result = engine.IsEngineRunning;

            // Assert

            Assert.Equal(expected, result);


        }
    }
}
