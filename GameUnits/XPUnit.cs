using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {

        //Proprietie XP, set only can be modified in this class, or in the ones
        //that extend XPUnit
        public int XP { get; protected set; }

        /// <summary>
        /// XPUnit constructor, sets the XP to 0
        /// </summary>
        /// <param name="movement"></param>
        /// <param name="health"></param>
        /// <returns></returns>
        public XPUnit(int movement, int health) : base(movement, health)
        {
            XP = 0;
        }

        /// <summary>
        /// Converts de object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + String.Format($" XP={XP}");
        }



    }
}