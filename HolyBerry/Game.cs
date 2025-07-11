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
            

            HolyBerry holyBerry = new HolyBerry(player);
            GrapeElixir grapeElixir = new GrapeElixir(player);

            new Battle(player, grapeslime);
            holyBerry.Reward();

            new Battle(player, new RottenRaspberry());
            grapeElixir.Reward();

            new Battle(player, new BlackberryBeast());
            holyBerry.Reward();

            new Battle(player, new BlueberryWitch());
            grapeElixir.Reward();

            new Battle(player, new StrawberryReaper());
            holyBerry.Reward();

            new Battle(player, new LordCherryDoom());

        }

        
        
    }
}
