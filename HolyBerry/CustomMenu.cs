using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class CustomMenu
    {
        string prompt;
        string[] options;
        public CustomMenu(string prompt, string[] options) 
        {
            this.prompt = prompt;
            this.options = options;
        }

        public int Run()
        {
            bool runMenu = true;
            int selectedIndex = 0;

            while (runMenu)
            {
                Console.WriteLine(prompt);

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

                    if (selectedIndex + 1 >= options.Length)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        selectedIndex++;
                    }

                    Console.Clear();

                }
                else if (keyPressed.Key == ConsoleKey.UpArrow)
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

                    //When Enter is pressed
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    runMenu = false;
                }
                else { Console.Clear(); }
            }

            return selectedIndex;
        }
    }
}
