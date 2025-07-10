using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Graphics
    {
        public void PrintTitle()
        {
            Console.WriteLine("\r\n ▄  █ ████▄ █    ▀▄    ▄     ███   ▄███▄   █▄▄▄▄ █▄▄▄▄ ▀▄    ▄ " +
                                "\r\n█   █ █   █ █      █  █      █  █  █▀   ▀  █  ▄▀ █  ▄▀   █  █  " +
                                "\r\n██▀▀█ █   █ █       ▀█       █ ▀ ▄ ██▄▄    █▀▀▌  █▀▀▌     ▀█   " +
                                "\r\n█   █ ▀████ ███▄    █        █  ▄▀ █▄   ▄▀ █  █  █  █     █    " +
                                "\r\n   █            ▀ ▄▀         ███   ▀███▀     █     █    ▄▀     " +
                                "\r\n  ▀                                         ▀     ▀            " +
                                "\r\n                                                               \r\n");
        }

        public string GetTitle()
        {
            return              "\r\n ▄  █ ████▄ █    ▀▄    ▄     ███   ▄███▄   █▄▄▄▄ █▄▄▄▄ ▀▄    ▄ " +
                                "\r\n█   █ █   █ █      █  █      █  █  █▀   ▀  █  ▄▀ █  ▄▀   █  █  " +
                                "\r\n██▀▀█ █   █ █       ▀█       █ ▀ ▄ ██▄▄    █▀▀▌  █▀▀▌     ▀█   " +
                                "\r\n█   █ ▀████ ███▄    █        █  ▄▀ █▄   ▄▀ █  █  █  █     █    " +
                                "\r\n   █            ▀ ▄▀         ███   ▀███▀     █     █    ▄▀     " +
                                "\r\n  ▀                                         ▀     ▀            " +
                                "\r\n                                                               \r\n";
        }

        public string GrapeSlime()
        {
            return "      ▓▓▓▓▓▓▓\r\n    ▓▓░░    ░░▓▓\r\n   ▓░  ●  ░  ● ░▓\r\n   ▓░    ▄▄     ░▓\r\n    ▓░  ▀▀    ░▓\r\n     ▓▓░░░░░░▓▓\r\n      ████████\r\n";
        }

        public string RottenRaspberry()
        {
            return "     ████████\r\n   ██░ x  ░ x ██   \r\n  ██░   ██     ░██\r\n  ██░  ▀▀▀▀    ░██\r\n   ▀▀████████▀▀\r\n     ▒▒▒▒▒▒▒▒\r\n    \r\n";
        }

        public string BlackberryBeast()
        {
            return "     █████████\r\n   ██░ ●   ░ ● ██   \r\n  ██░   ████    ░██\r\n  ██░  ▄████▄   ░██\r\n   ██░ ▀▀▀▀▀▀ ░██\r\n    ▀▀████████▀▀\r\n     ░░╔════╗░░\r\n        ░░░░\r\n";
        }

        public string BlueberryWitch()
        {
            return "      ░░████░░\r\n     ██░ o  ░o ██   \r\n    ██░   ██    ░██\r\n   ██░  ░▀▀▀░░  ░██\r\n  ▓▓░  ║██║██║  ░▓▓\r\n   ▀▀██████████▀▀\r\n      ║    ║\r\n     ████████\r\n";
        }

        public string StrawberryReaper()
        {
            return "     ██████████\r\n   ██░  x   ░ x ██  \r\n  ██░   ▓▓▓▓    ░██\r\n  ██░   ▓▓▓▓    ░██\r\n   ▓▓░ ░▀▀▀▀ ░ ░▓▓\r\n    ▀▀████████▀▀\r\n     ║█╔════╗█║\r\n     ║█║███║█║\r\n      ║     ║\r\n     ║║     ║║\r\n     ╚╝     ╚╝\r\n";
        }

        public string LordCherryDoom()
        {
            return "      ██████████\r\n    ██░  ⚉   ░ ⚉ ██   \r\n   ██░    ████    ░██\r\n  ██░   ░████░░   ░██\r\n  ██░  ░░▀▀▀▀░░   ░██\r\n   ▓▓▓░ ▓▓▓▓▓▓ ░ ▓▓▓\r\n     ▓▓████████▓▓\r\n     ██╔══════╗██\r\n     ██║██████║██\r\n     ██║      ║██\r\n     ╚═╝      ╚═╝\r\n";
        }

        public string YouWin()
        {
            return @"
▓██   ██▓ ▒█████   █    ██     █     █░ ██▓ ███▄    █  ▐██▌ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▓█░ █ ░█░▓██▒ ██ ▀█   █  ▐██▌ 
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒█░ █ ░█ ▒██▒▓██  ▀█ ██▒ ▐██▌ 
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░█░ █ ░█ ░██░▓██▒  ▐▌██▒ ▓██▒ 
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░░██▒██▓ ░██░▒██░   ▓██░ ▒▄▄  
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒    ░ ▓░▒ ▒  ░▓  ░ ▒░   ▒ ▒  ░▀▀▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░      ▒ ░ ░   ▒ ░░ ░░   ░ ▒░ ░  ░ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░      ░   ░   ▒ ░   ░   ░ ░     ░ 
 ░ ░         ░ ░     ░            ░     ░           ░  ░    
 ░ ░                                                        
";
        }

        public string YouLose()
        {
            return @"
▓██   ██▓ ▒█████   █    ██     ██▓     ▒█████    ██████ ▓█████  ▐██▌ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▓██▒    ▒██▒  ██▒▒██    ▒ ▓█   ▀  ▐██▌ 
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒██░    ▒██░  ██▒░ ▓██▄   ▒███    ▐██▌ 
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ▒██░    ▒██   ██░  ▒   ██▒▒▓█  ▄  ▓██▒ 
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░██████▒░ ████▓▒░▒██████▒▒░▒████▒ ▒▄▄  
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒    ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░░ ▒░ ░ ░▀▀▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░    ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░ ░ ░  ░ ░  ░ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░      ░ ░   ░ ░ ░ ▒  ░  ░  ░     ░       ░ 
 ░ ░         ░ ░     ░            ░  ░    ░ ░        ░     ░  ░ ░    
 ░ ░                                                                 
";
        }

        public void AboutScreen()
        {
            Console.Clear();

            PrintTitle();
            Console.WriteLine("\r\nHolyBerry is a text-based One-Shot RPG game where you can explore, fight monsters, and collect items." +
                                "\r\nDeveloped by Jeff Matthew Molina in 2025 (because he doesnt know how to code anymore)." +
                                "\r\n\nPress any key to return to the Main Menu.");
            Console.ReadKey();
            Console.Clear();
            new MainMenu();
        }

    }
}
