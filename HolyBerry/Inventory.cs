using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Inventory()
    {
        public List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void UseItem(Item item)
        {
            item.Use();
        }

        public void ListItems()
        {
            if (items.Count < 0)
            {
                Console.WriteLine("\nInventory:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].name}");
                    
                }
            }
            else
            {
                Console.WriteLine("\nInventory: \nYou dont have any items at the moment.");
            }
        }

    }
}
