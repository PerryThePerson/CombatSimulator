using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior player = new Warrior();
            Warrior enemy = new Warrior();

            Battle.Simulate(player, enemy);
        }
    }
}
