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
            bool runMainMenu = true;
            int selectedIndex = 0;
            while (runMainMenu)
            {
                new Graphics().PrintTitle();
                Console.WriteLine("Use UP and DOWN arrow keys to navigate. Use ENTER to Select option.");
                string[] options = { "Start", "Exit" };

                for (int i = 0; i < options.Length; i++)
                {
                    if (selectedIndex == i)
                    {
                        Console.WriteLine($" << {options[i]} >> ");
                    }
                    else
                    {
                        Console.WriteLine($"    {options[i]}    ");
                    }

                }

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);


                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
               
                    if(selectedIndex+1 >= options.Length)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        selectedIndex++;
                    }
                        
                    Console.Clear();

                } else if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (selectedIndex - 1 < 0)
                    {
                        selectedIndex = options.Length - 1;
                    }
                    else
                    {
                        selectedIndex--;
                    }

                    Console.Clear();
                }else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    if(selectedIndex == 0)
                    {
                        Console.Clear();
                        runMainMenu = false;
                        new Game();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else { Console.Clear(); }
            }

        }
        
    }
}
