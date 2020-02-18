using System;
using System.Collections.Generic;
using System.Text;


namespace WarriorBattle
{
    public class Warrior
    {
        //name, health, attackMaximum, blockMaximum
        //constructor to initialise and create the objects for us
        //need randomisation of numbers
        //warrior capabilities as methods

        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double MaxAttackLevel { get; set; } = 0;
        public double MaxBlockAbility { get; set; } = 0;

        public Random rand = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            MaxAttackLevel = attackMax;
            MaxBlockAbility = blockMax;
        }

        //= attack - generate a random attack from 1 up to maximumAttack

        public double Attack()
        {
            return rand.Next(1, (int)MaxAttackLevel);
        }

        //= block - generate a random block level from 1 up to maximumBlock

        public double Block()
        {
            return rand.Next(1, (int)MaxBlockAbility);
        }
    }
}