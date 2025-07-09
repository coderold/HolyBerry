using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Battle
    {
        private Player player;
        private Enemy enemy;
        private bool runBattleLoop = true;

        public Battle(Player player, Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
            
            //Console.WriteLine($"{enemy.Name} Appears!");

            BattleLoop();
            
        }

        private void BattleLoop()
        {

            string prompt = $"\n{new Graphics().GrapeSlime()}" +
                            $"\n{player.Name}: {player.HP} HP" +
                            $"\n{enemy.Name}: {enemy.HP} HP" +
                            $"\n\nYour Turn:";
            string[] choices = { "Attack", "Use Item"};

            while (runBattleLoop)
            {

                //Console.WriteLine($"{player.Name}: {player.HP}");
                //Console.WriteLine($"{enemy.Name}: {enemy.HP}\n");

                CustomMenu menu = new CustomMenu(prompt, choices);

                int selectedIndex = menu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        PlayerAttack();
                        CheckAttackResult();
                        break;

                }

                if (enemy.IsAlive)
                {
                    EnemyTurn();
                }
                

                Console.ReadKey();
                Console.Clear();

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

        private void CheckAttackResult()
        {
            runBattleLoop = player.IsAlive && enemy.IsAlive? true : false;
        }

        private void PlayerAttack()
        {
            if (doesAttackHit(player.HitChance))
            {
                player.Attack(enemy);

                if (enemy.HP <= 0)
                {
                    Console.WriteLine(new Graphics().YouWin());
                }

            }
            else
            {
                Console.WriteLine("Your Attack Failed!");
            }
        }

        private void EnemyTurn()
        {
            if (doesAttackHit(enemy.HitChance))
            {
                enemy.Attack(player);

                if (!player.IsAlive)
                {
                    Console.WriteLine("You ded!");
                }
            }
            else
            {
                Console.WriteLine($"{enemy.Name} Attack Failed!");
            }
        }
    }
}
