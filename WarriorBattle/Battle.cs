using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorBattle
{
    //this is a utility class where the actions are static
    public class Battle
    {
        //startFightAbility
        //warrior1, warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {//loop the chance to attack and block, and takes turns until one dies.
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorA_attackAmount = warriorA.Attack();
            double warriorB_blockAmount = warriorB.Block();
            double damageToWarriorB = warriorA_attackAmount - warriorB_blockAmount;
            //GetAttackResult - warriorA, warriorB

            //calculate 1 warriors attack and the others block
            if (damageToWarriorB > 0)
            {
                warriorB.Health = warriorB.Health - damageToWarriorB;
            }
            else
            {
                damageToWarriorB = 0;
            }

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage.", warriorA.Name, warriorB.Name, damageToWarriorB);
            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious!\n", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }

        //subtract block from attack. if there was damage, subtract that damage from the health of the other one.
        //print info of who attack and for how much damage, and then for changes in health.
        //check if health below zero - if so print a message of who died and won, and end the loop.
    }
}