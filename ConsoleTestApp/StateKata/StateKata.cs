using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;


namespace ConsoleTestApp.StateKata
{
    

    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }

    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }

    public class SiegeState : IUnitState
    {
        public SiegeState()
        {
            CanMove = false;
            Damage = 20;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class TankState : IUnitState
    {
        public TankState()
        {
            CanMove = true;
            Damage = 5;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class Tank : IUnit
    {
        public Tank()
        {
            State = new TankState();
        }

        public static string sum(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
                a = "0";

            if (string.IsNullOrEmpty(b))
                b = "0";

            
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }

        public IUnitState State { get; set; }

        public bool CanMove => State.CanMove;
        public int Damage => State.Damage;
    }
}
