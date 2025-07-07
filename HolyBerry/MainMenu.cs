using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class MainMenu
    {
        public MainMenu()
        {
            string prompt = $"{new Graphics().GetTitle()}" +
                $"Use UP and DOWN arrow keys to navigate. Use ENTER to Select option.\n";
            string[] options = { "Start", "About", "Exit" };           

            Console.Clear();
            CustomMenu mainMenu = new CustomMenu(prompt, options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.Clear();
                    new Game();
                    break;
                case 1:
                    new Graphics().AboutScreen();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }

        }

        private void RunGame()
        {

        }

        private void ExGame()
        {

        }

        

    }
}
