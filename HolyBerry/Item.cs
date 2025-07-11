using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public abstract class Item
    {
        public string name { get; set; } = "";
        public string type { get; set; } = "";
        public string description { get; set; } = "";
        public int quantity { get; set; }
        public Player player { get; set; }

        public Item(Player player)
        {
            this.player = player;
        }

        public abstract void effect();
        
        public void Use()
        {
            Console.WriteLine(new Graphics().Result());
            this.effect();
            this.quantity--;
            Console.WriteLine($"\n- {player.Name} used a {type}: {name}");
        }

        public void Reward()
        {
            this.quantity++;
            Console.WriteLine(new Graphics().Wow());
            Console.WriteLine($"Congratulations! You found a {this.name} ({this.description})");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }

    public class HolyBerry: Item
    {
        public HolyBerry(Player player) : base(player)
        {
            this.name = "Holy Berry";
            this.type = "Potion";
            this.description = "Restores 30 HP";
            this.quantity = 0;
            player.inventory.AddItem(this);

        }
        public override void effect()
        {
            player.HP += 30;
        }

    }

    public class GrapeElixir : Item
    {
        public GrapeElixir(Player player) : base(player)
        {
            this.name = "Grape Elixir";
            this.type = "Buff Item";
            this.description = "Grants you +5 damage.";
            this.quantity = 0;
            player.inventory.AddItem(this);

        }
        public override void effect()
        {
            player.AttackDamage += 5;
        }

    }
}
