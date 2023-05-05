using System;

namespace GameUnits
{
    class Program
    {
        private static void Main()
        {
            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 5),
                new MilitaryUnit(4, 5, 2),
                new SettlerUnit(),
            };

            // Unidade 0 ataca unidade 1
            (units[0] as MilitaryUnit).Attack(units[1]);
            // Unidade 0 ataca unidade 2
            (units[0] as MilitaryUnit).Attack(units[2]);

            // "Imprimir" cada unidade
            // chamando implicitamente o método ToString() de cada uma delas
            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }

            // Output esperado:
            //
            // MilitaryUnit: HP=12 COST=7 AP=5 XP=2
            // MilitaryUnit: HP=4 COST=3 AP=3 XP=0
            // SettlerUnit: HP=1 COST=5
        }
        /*static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit militar = new MilitaryUnit();
            militar.Attack(settler);
            settler.Move();
            militar.Move();
            Console.WriteLine($"Settler cost = {settler.Cost}");
            Console.WriteLine($"Settler health = {settler.Health}");
            Console.WriteLine($"Militar cost = {militar.Cost}");
            Console.WriteLine($"Militar health = {militar.Health}");
        }*/
    }
}
