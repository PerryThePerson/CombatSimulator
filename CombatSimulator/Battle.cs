using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Battle
    {
        public static Warrior simulationPlayer;
        public static Warrior simulationEnemy;

        public static void Simulate(Warrior player, Warrior enemy)
        {

            simulationPlayer = player;
            simulationEnemy = enemy;

            while(player.alive && enemy.alive)
            {
                char attackAction = AttackSelectionMenu();
                SimulatePlayerAttack(attackAction);

            }
            
        }

        public static char AttackSelectionMenu()
        {
            char input;

            Console.WriteLine("1. Swing towards Head");
            Console.WriteLine("2. Swing towards Left Arm");
            Console.WriteLine("3. Swing towards Right Arm ");
            Console.WriteLine("4. Swing towards Torso");
            Console.WriteLine("5. Swing toward Left Leg");
            Console.WriteLine("6. Swing towards Right Leg");



            input = Console.ReadKey().KeyChar;

            Console.Clear();

          
            return input;


        }

        public static void SimulatePlayerAttack(char attackAction)
        {
            int damage;
            switch(attackAction)
            {
                case '1':
                    Console.WriteLine("player swings toward his enemies head! \n \n");
                    break;
                case '2':
                    Console.WriteLine("player swings toward his enemies left arm! \n \n");
                    break;
                case '3':
                    Console.WriteLine("player swings toward his enemies right arm! \n \n");
                    break;
                case '4':
                    Console.WriteLine("player swings toward his enemies torso! \n \n");
                    damage = CalculateDamage(attackAction);
                    ApplyDamage(attackAction, damage);

                    break;
                case '5':
                    Console.WriteLine("player swings toward his enemies left leg! \n \n");
                    break;
                case '6':
                    Console.WriteLine("player swings toward his enemies right leg! \n \n");
                    break;
                default:
                    Console.WriteLine("Input not valid. Please hit 1-6. \n \n ");
                    break;



            }

        }

        public static int CalculateDamage(char attackSelection)
        {
            int agilityDifference = simulationEnemy.agility - simulationPlayer.agility;
            int baseAttack = simulationPlayer.strength;
            int damage = 0;
            bool hit = CalculateHitChance(agilityDifference);

            if (hit)
            {
                switch (attackSelection)
                {
                    case '1':
                        Console.WriteLine("player swings toward his enemies head! \n \n");
                        break;
                    case '2':
                        Console.WriteLine("player swings toward his enemies left arm! \n \n");
                        break;
                    case '3':
                        Console.WriteLine("player swings toward his enemies right arm! \n \n");
                        break;
                    case '4':
                        damage = simulationPlayer.strength - simulationEnemy.torsoArmor;
                        if(damage > 0)
                        {
                            return damage;
                        }
                        break;
                    case '5':
                        Console.WriteLine("player swings toward his enemies left leg! \n \n");
                        break;
                    case '6':
                        Console.WriteLine("player swings toward his enemies right leg! \n \n");
                        break;
                    default:
                        Console.WriteLine("Input not valid. Please hit 1-6. \n \n ");
                        break;

                }

            }
            else
            {
                Console.WriteLine("You missed!");
            }
            return 0;
        }

        public static void ApplyDamage(char attackSelection, int damage)
        {
            switch (attackSelection)
            {
                case '1':
                    Console.WriteLine("player swings toward his enemies head! \n \n");
                    break;
                case '2':
                    Console.WriteLine("player swings toward his enemies left arm! \n \n");
                    break;
                case '3':
                    Console.WriteLine("player swings toward his enemies right arm! \n \n");
                    break;
                case '4':
                    simulationEnemy.health -= damage;
                    Console.WriteLine("The Player did " + damage + " damage to his oponents health!");
                    if(simulationEnemy.health <= 0)
                    {
                        simulationEnemy.alive = false;
                        Console.WriteLine("The enemy has died!");
                        Console.Read();
                    }
                    
                    break;
                case '5':
                    Console.WriteLine("player swings toward his enemies left leg! \n \n");
                    break;
                case '6':
                    Console.WriteLine("player swings toward his enemies right leg! \n \n");
                    break;
                default:
                    Console.WriteLine("Input not valid. Please hit 1-6. \n \n ");
                    break;

            }
        }

        public static bool CalculateHitChance(int agilityDifference)
        {
            Random rand = new Random();
            if (agilityDifference <= 0)
            {
             
                if(rand.Next(0, 100) > 50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(agilityDifference > 0 && agilityDifference < 10)
            {
                if(rand.Next(0, 100) > 40)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            else if(agilityDifference > 10)
            {
                if(rand.Next(0, 100) > 30)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }

            return false;
        }
    }
}
