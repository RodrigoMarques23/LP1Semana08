using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health { get => base.Health + XP; set => base.Health = value; }
        public override float Cost { get => AttackPower + XP; }
        public MilitaryUnit(int movement, int health, int attackPower)
        : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
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
        /// Converts de object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + String.Format(" AP={0,1} XP={1,1}", AttackPower, XP);
        }
    }
}