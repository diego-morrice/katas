using System;
using System.Runtime.Remoting.Messaging;


namespace ConsoleTestApp.Car
{
    public interface ICar
    {
        bool EngineIsRunning { get; }

        void EngineStart();

        void EngineStop();

        void Refuel(double liters);

        void RunningIdle();
    }

    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }

    public interface IFuelTank
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }

        void Consume(double liters);

        void Refuel(double liters);
    }

    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }

    public class Car : ICar
    {
        public IFuelTankDisplay fuelTankDisplay;

        private IEngine engine;

        private IFuelTank fuelTank;

        public Car()
        {
            fuelTank = new FuelTank();
            engine = new Engine(fuelTank);
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
        }

        public Car(double fuelLevel)
            : this()
        {
            fuelTank.Refuel(fuelLevel);
        }

        public bool EngineIsRunning => engine.IsRunning;

        public void EngineStart()
        {
            engine.Start();
        }

        public void EngineStop()
        {
            engine.Stop();
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            engine.Consume(0.0003);
        }
    }

    public class Engine : IEngine
    {
        private readonly IFuelTank _fuelTank;

        public Engine(IFuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public bool IsRunning { get; private set; }
        public void Consume(double liters)
        {
            if (!IsRunning)
                return;

            if (_fuelTank.FillLevel == 0)
            {
                Stop();
                return;
            }

            _fuelTank.Consume(liters);
        }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            IsRunning = false;
        }
    }

    public class FuelTank : IFuelTank
    {
        private const int Capacity = 60;
        public double FillLevel { get; private set; }

        public bool IsOnReserve => FillLevel < 5 && FillLevel > 0;

        public bool IsComplete => FillLevel == 60;

        public void Consume(double liters)
        {
            FillLevel = (FillLevel - liters) > 0 ? 0 : FillLevel - liters;
        }

        public void Refuel(double liters)
        {
            if(liters < 0 )
                return;
            
            FillLevel = (FillLevel + liters) > Capacity ? Capacity : FillLevel + liters;
        }
    }

    public class FuelTankDisplay : IFuelTankDisplay
    {
        private readonly IFuelTank _fuelTank;

        public FuelTankDisplay(IFuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public double FillLevel => Math.Round(_fuelTank.FillLevel, 2);
        public bool IsOnReserve => _fuelTank.IsOnReserve;
        public bool IsComplete => _fuelTank.IsComplete;
    }
}
