using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class DiplomatUnit : XPUnit
    {
        //Propritie cost, make it costing 7.1 for Diplomat unit
        public override float Cost { get => 7.1f; }
        //Setting values for Diplomat unit Constructor
        public DiplomatUnit(int movement = 6, int health = 1) : base(movement, health){}

        /// <summary>
        /// Verifys if unit is a specific unit, and if so
        /// increment x XP, dependent what unit it is
        /// </summary>
        /// <param name="unit"></param>
        public void MakeAgreement(Unit unit)
        {
            if (unit is DiplomatUnit)
            {
                XP += 3;
            }
            else if (unit is SettlerUnit)
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