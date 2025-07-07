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

            string prompt = "MagjakolMagjakolMagjakolMagjakolMagjakolMagjakolMagjakolMagjakol\n";
            string[] options = { "Magjakol", "Magjakol", "Magjakol" };

            CustomMenu pepe = new CustomMenu(prompt, options);
            int selectedIndex = pepe.Run();

            switch(selectedIndex)
            {
                case 0:
                    Console.WriteLine("jakol1");
                    break;
                case 1:
                    Console.WriteLine("jakol2");
                    break;
                case 2:
                    Console.WriteLine("jakol3");
                    break;
            }

        }

        
        
    }
}
