using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Battle
    {
        public Battle(Player player, Enemy enemy)
        {
            int round = 1;
            Console.WriteLine(new Graphics().GrapeSlime());

            while(player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"ROUND: {round}\n");

                Console.WriteLine($"{player.Name}: {player.HP}");
                Console.WriteLine($"{enemy.Name}: {enemy.HP}\n");

                if (doesAttackHit(player.HitChance))
                {
                    player.Attack(enemy);

                    if (!enemy.IsAlive)
                    {
                        Console.WriteLine("enemy ded");
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Your Attack Failed!");
                }

                if (doesAttackHit(enemy.HitChance))
                {
                    enemy.Attack(player);

                    if (!player.IsAlive)
                    {
                        Console.WriteLine("You ded!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{enemy.Name} Attack Failed!");
                }

                Console.ReadKey();
                Console.Clear();
                round++;
            }
        }

        private bool doesAttackHit(int HitChance)
        {
            Random dice = new Random();

            if(HitChance >= dice.Next(1, 100))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
