using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Enemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int AttackDamage { get; set; }

        public Enemy(int HP, int AttackDamage)
        {
            this.HP = HP;
            this.AttackDamage = AttackDamage;
        }

        public void Attack(Player player)
        {
            player.takeDamage(AttackDamage);
        }

        public void takeDamaege(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{Name} has taken damage.\nHP: {HP}");
        }

    }

    public class GrapeSlime: Enemy
    {
        public GrapeSlime(int HP, int AttackDamage) : base(HP, AttackDamage)
        {
            this.Name = "Grape Slime";
            Console.WriteLine($"my name is {Name} with {HP} and {AttackDamage} attack damage.");
        } 

    }
}
