using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health { get => base.Health + XP; set => base.Health = value; }
        public override float Cost { get => AttackPower + XP; }
        public MilitaryUnit() : base(5, 3) { }
        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }
    }
}