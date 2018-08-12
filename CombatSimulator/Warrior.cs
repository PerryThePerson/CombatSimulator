using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Warrior
    {
        public int strength { get; set ; }
        public int agility { get; set; }
        public int experience { get; set; }
        public int headHealth { get; set; }
        public int leftArmHealth { get; set; }
        public int rightArmHealth { get; set; }
        public int torsoHealth { get; set; }
        public int leftLegHealth { get; set; }
        public int rightLegHealth { get; set; }
        public int health { get; set; }
        public bool alive { get; set; }


        public Warrior()
        {
            //stats
            strength = 10;
            agility = 1;
            experience = 1;

            //health
            headHealth = 100;
            leftArmHealth = 100;
            rightArmHealth = 100;
            torsoHealth = 100;
            leftLegHealth = 100;
            rightLegHealth = 100;
            health = 100;

            alive = true;

        }


    }
}
