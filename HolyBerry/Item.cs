using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Item
    {
        public string name;
        public string type;
        
        public Item(string name, string type)
        {
            this.name = name;
            this.type = type;

        }
        public void Use()
        {
            Console.WriteLine($"{name} is used!");
        }
    }
}
