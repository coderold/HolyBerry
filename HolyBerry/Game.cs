using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Game
    {
        public Game() 
        {
            new Graphics().PrintTitle();

            Console.Write("Your Name: ");
            Player player = new Player(Console.ReadLine());

            Console.Clear();

            new Graphics().PrintTitle();
            player.PrintPlayerStats();

            Console.ReadKey();
            Console.Clear();

            Enemy grapeslime = new GrapeSlime();

            new Battle(player, grapeslime);
        }

        
        
    }
}
