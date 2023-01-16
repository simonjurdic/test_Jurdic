using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurdicTest
{

    public class Soldier
    {
        private int health;
        private int maxHealth;
        private int shield;
        private int damage;
        private int maxShield;
        private int level;


        public string Name { get; }
        public int Hp { get => health; }
        public int MaxHp { get => maxHealth; }
        public int Damage { get => damage; }
        public int MaxShield { get => maxShield; }
        public int Level { get => level; }
        public int MyProperty { get; set; } 

        public Soldier(string name)
        {
            Name = name;
            health = 50;
            maxHealth = 100;
            maxShield = 50;
            shield = 25;
            damage = 8;

        }


        public void GetHit(int damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                health += shield;
                shield = 0;
            }
            health = Math.Max(0, health);

        }
        public void Heal(int heal)
        {
            health += heal;
            health = Math.Min(maxHealth, health);
        }
        public void LevelUp()
        {
            damage += 2;
            maxHealth += 5;
            maxShield += 5;
            level++;
        }

        public override string ToString()
        {
            string text = "Name: " + Name + "\n";
            text += "Health:  " + Hp + "\n";
            text += "Max Hp:  " + MaxHp + "\n";
            text += "Damage:  " + damage + "\n";
            text += "Shield:  " + shield + "\n";
            text += "Max Shield:  " + maxShield + "\n";
            text += "Level:  " + level + "\n";
            return text;
        }

    }


}

