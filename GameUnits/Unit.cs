using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        /// <summary>
        /// Prints how many slots the unit moves
        /// </summary>
        public void Move()
        {
            Console.WriteLine($"You moved {movement} slots");
        }

        /// <summary>
        /// Converts de object to a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(
                "{0}:  HP={1:d} COST={2:f0}", this.GetType().Name, Health, Cost);
        }
    }
}