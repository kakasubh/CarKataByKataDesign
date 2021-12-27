namespace CarKataByKataDesign.Contracts
{
    public interface IEngine
    {
        public bool IsEngineRunning { get; }

        public void StartEngine();

        public void StopEngine();
    }
}
