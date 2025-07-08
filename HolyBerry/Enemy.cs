using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolyBerry
{
    public class Enemy
    {
        public string Name { get; set; } = "";
        public int HP { get; set; }
        public int AttackDamage { get; set; }
        public string AttackStyle { get; set; } = "";
        public string Dialog { get; set; } = "";
        public int HitChance { get; set; }
        public bool IsAlive { get; set; } = true;

        public void Attack(Player player)
        {
            player.takeDamage(AttackDamage);
        }

        public void takeDamaege(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{Name} has taken damage.");

            if( HP <= 0)
            {
                IsAlive = false;
            }
        }

        public void sayDiaglog()
        {
            Console.WriteLine($"{Name}: {Dialog}");
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

    public class GrapeSlime: Enemy
    {
        
        public GrapeSlime()
        {
            this.Name = "Grape Slime";
            this.HP = 10;
            this.AttackDamage = 5;
            this.AttackStyle = "Melee Jab";
            this.HitChance = 25;
            this.Dialog = "Legends lang nakakaalm haha.";
        }

    }

    public class RottenRaspberry : Enemy
    {

        public RottenRaspberry()
        {
            this.Name = "Rotten Raspberry";
            this.HP = 15;
            this.AttackDamage = 6;
            this.AttackStyle = "Acid Spit";
            this.HitChance = 30;
            this.Dialog = "Batang 90's lang nakakalamm.";
        }

    }

    public class BlackberryBeast : Enemy
    {

        public BlackberryBeast()
        {
            this.Name = "Blackberry Beast";
            this.HP = 30;
            this.AttackDamage = 8;
            this.AttackStyle = "Claw Swipe";
            this.HitChance = 40;
            this.Dialog = "Alammm mo haaaaaaaaa.";
        }

    }

    public class BlueberryWitch : Enemy
    {

        public BlueberryWitch()
        {
            this.Name = "Blueberry Witch";
            this.HP = 40;
            this.AttackDamage = 10;
            this.AttackStyle = "Hex Beam";
            this.HitChance = 50;
            this.Dialog = "Ampuki nabasa.";
        }

    }

    public class StrawberryReaper : Enemy
    {

        public StrawberryReaper()
        {
            this.Name = "Strawberry Reaper";
            this.HP = 50;
            this.AttackDamage = 12;
            this.AttackStyle = "Scythe Slash";
            this.HitChance = 65;
            this.Dialog = "Babad na babad nako dito oh.";
        }

    }

    public class LordCherryDoom : Enemy
    {

        public LordCherryDoom()
        {
            this.Name = "Lord Cherry Doom";
            this.HP = 0;
            this.AttackDamage = 15;
            this.AttackStyle = "Cherry Bomb";
            this.HitChance = 75;
            this.Dialog = "Arayyy koooooo.";
        }

    }


}
