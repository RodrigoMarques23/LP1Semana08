using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        public override float Cost { get => 7.1f; }
        public DiplomatUnit(int movement, int health, int xp) : base(6, 1, 0)
        {

        }
        public void MakeAgreement(Unit unit)
        {
            if (unit is DiplomatUnit)
            {
                XP += 3;
            }
            if (unit is SettlerUnit)
            {
                XP += 2;
            }
            else
            {
                XP += 1;
            }

        }
    }
}