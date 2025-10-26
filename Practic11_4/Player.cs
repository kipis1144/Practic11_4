using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practic11_4
{
    internal class Player
    {
        private int level;
        private int health;
        private string name;
        private bool isAlive;
        public int Level{ 
            get { return level; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else {
                    Console.WriteLine("Уровень должен быть в диапазоне 1-100.");
                }
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
                else
                {
                    Console.WriteLine("Уровень должен быть в диапазоне 1-100.");
                }
            }
        }
        public string Name {
            get { return name; }
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else Name = "Init";
            }
        }
        public bool IsAlive {
            get => isAlive && health > 0; // Проверяем оба условия
            set => isAlive = value;
        }
        public Player (int level, int health) { 
            Level = level;
            Health = health;
            IsAlive = true;
        }
        public void TakeDamage(int damage) { 
            Health = Health - damage;
            Console.WriteLine($"Игрок: Alex, уровень: {Level}, здоровье: {Health}, жив: {IsAlive}");
        }
    }
}
