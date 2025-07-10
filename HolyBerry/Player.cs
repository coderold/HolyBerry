using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Player
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public bool IsAlive { get; set; } = true;
        public int HitChance {  get; set; }

        public Inventory inventory { get; set; }
        
        public Player(string Name)
        {
            this.Name = Name;
            this.HitChance = 60;
            HP = 20;
            inventory = new Inventory();
            Console.WriteLine($"Greetings! {Name}");
        }

        public void PrintPlayerStats()
        {
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"HP         : {HP}");
            inventory.ListItems();
            
        }

        public void takeDamage(int damage)
        {
            HP -= damage;
            //Console.WriteLine($"You've been Hit with a {damage}dmg");
        }

        public void Attack(Enemy enemy)
        {
            //should accept an enemy and then attack that enemy
            //enemy health - attack dmg depends on the weapon
            enemy.takeDamaege(5);
            Console.WriteLine($"\n- You attacked {enemy.Name} with 5 damgage");

        }

        //public bool isAlive()
        //{
        //    if (HP <= 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

    }
}
