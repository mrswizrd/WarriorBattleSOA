using System;

namespace WarriorBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Warrior clayMorrow = new Warrior("Clay Morrow", 1000, 120, 40);

            Warrior JaxTeller = new Warrior("Jax Teller", 1000, 120, 40);

            Battle.StartFight(clayMorrow, JaxTeller);
            Console.ReadLine();
        }
    }
}