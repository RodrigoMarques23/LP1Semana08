using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost { get => 5; }
        public SettlerUnit() : base(1, 2) { }

    }
}