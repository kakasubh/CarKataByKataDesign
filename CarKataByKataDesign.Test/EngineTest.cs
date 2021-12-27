using CarKataByKataDesign.Contracts;
using Xunit;

namespace CarKataByKataDesign.Test
{
    public class EngineTest
    {
        private Engine engine = new Engine();

        [Fact]
        public void StartEngine_Test()
        {
            // Arrange 

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
            // Arrange 

            bool expected = false;

            // Act

            engine.StopEngine();

            bool result = engine.IsEngineRunning;

            // Assert

            Assert.Equal(expected, result);


        }
    }
}
