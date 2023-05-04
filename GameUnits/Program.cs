using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit militar = new MilitaryUnit();
            //militar.Attack();
            settler.Move();
            militar.Move();
            Console.WriteLine($"Settler cost = {settler.Cost}");
            Console.WriteLine($"Settler health = {settler.Health}");
            Console.WriteLine($"Militar cost = {militar.Cost}");
            Console.WriteLine($"Militar health = {militar.Health}");
        }
    }
}
