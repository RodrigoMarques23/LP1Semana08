using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; }

        //Propriete Health overriden, putting health equals from xp unit + xp
        public override int Health { get => base.Health + XP; set => base.Health = value; }
        
        //Proprietie cost overriden, putting the cost = Attack power + xp
        public override float Cost { get => AttackPower + XP; }
        
        //Miltary unit Constructor
        public MilitaryUnit(int movement, int health, int attackPower)
        : base(movement, health)
        {
            AttackPower = attackPower;
        }

        /// <summary>
        /// Receives a unit
        /// Implement XP
        /// Decrement health from the attacked unit
        /// </summary>
        /// <param name="u"></param>
        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + String.Format(" AP={0,1}", AttackPower);
        }
    }
}