using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            
            Console.WriteLine($"{enemy.Name} Appears!\n");
            Console.WriteLine(enemy.Illustration);
            Console.WriteLine($"- {enemy.Name}: {enemy.Dialog}");
            Console.WriteLine("\nPress any key to start the battle");
            Console.ReadKey();
            Console.Clear();

            BattleLoop();
            
        }

        private void BattleLoop()
        {
            

            while (runBattleLoop)
            {
                string prompt = $"\n{enemy.Illustration}" +
                                $"\n{player.Name}: {player.HP} HP" +
                                $"\n{enemy.Name}: {enemy.HP} HP" +
                                $"\n\nYour Turn:\n";

                string[] choices = { "Attack", "Use Item" };

                CustomMenu menu = new CustomMenu(prompt, choices);

                int selectedIndex = menu.Run();

                Console.Clear();

                switch (selectedIndex)
                {
                    case 0:
                        PlayerAttack();
                        CheckAttackResult();
                        break;

                    case 1:
                        Console.Clear();
                        UseItem();
                        break;
                }

                if (enemy.IsAlive)
                {
                    EnemyTurn();
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }

        }

        private void UseItem()
        {
            
            string[] choices = itemChoices();

            if (choices.Length > 0)
            {
                CustomMenu menu = new CustomMenu("Items:", choices);

                int selectedIndex = menu.Run();
                Console.Clear();
                
                string itemName = choices[selectedIndex];

#pragma warning disable CS8602 // Dereference of a possibly null reference.
                player.inventory.items.Find(x => x.name == itemName).Use();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                player.inventory.ListItems();
                Console.WriteLine("\nPress any key to go back...");
                Console.ReadKey();
                Console.Clear();
                BattleLoop();
            }
        }

        private string[] itemChoices()
        {
            List<Item> items = player.inventory.items;
            LinkedList<string> choices = new LinkedList<string>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].quantity > 0)
                {
                    choices.AddLast(items[i].name);
                }

            }

            return choices.ToArray();
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
                    Console.Clear() ;
                    Console.WriteLine($"\n{enemy.Name} has been defeated!");
                    Console.WriteLine(new Graphics().YouWin());
                }

            }
            else
            {
                Console.WriteLine("\n- Your Attack Failed!");
            }
        }

        private void EnemyTurn()
        {
            if (doesAttackHit(enemy.HitChance))
            {
                enemy.Attack(player);

                if (!player.IsAlive)
                {
                    Console.WriteLine(new Graphics().YouLose());
                    Console.WriteLine("\n\nThank you for Playing!!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine($"\n- {enemy.Name} Attack Failed!");
            }
        }
    }
}
