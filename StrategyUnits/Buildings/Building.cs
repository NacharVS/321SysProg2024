using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Building
    {
        private int _health;

        public string Name { get; set; }
        public int Health
        {
            get { return _health; }
            set
            {
                if (_health < 0)
                    _health = 0;
                else if (_health > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
            }
        }
        public int MaxHealth { get; private set; }

        public Building(string name, int health)
        {
            Name = name;
            MaxHealth = health;
            _health = health;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Здание: {Name} | Здоровье: {Health}");
        }
    }
}
