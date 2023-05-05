using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        public int XP { get; protected set; }
        public XPUnit(int movement, int health, int xp) : base(movement, health)
        {
            XP = xp;
            xp = 0;
        }

        /*public override string ToString()
        {
            return base.ToString() + String.Format();
        }*/



    }
}