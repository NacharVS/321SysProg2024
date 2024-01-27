using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyUnits.Units.Unit;

namespace StrategyUnits.Buildings
{
    internal class Building : IBuildingHealth
    {
        private int _health;
        public string Name { get; set; }
        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    HealthStayedEvent?.Invoke(0, MaxHealth);
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    HealthIncreasedEvent?.Invoke(MaxHealth, MaxHealth);
                    _health = MaxHealth;
                }
                else if (value == _health)
                {
                    HealthStayedEvent?.Invoke(value, MaxHealth);
                }
                else
                {
                    if (value > _health)
                        HealthIncreasedEvent?.Invoke(value, MaxHealth);
                    else
                        HealthDecreasedEvent?.Invoke(value, MaxHealth);

                    _health = value;
            }
        }
        }
        public int MaxHealth { get; set; }

        public Building(string name, int health)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"{Name} получил {damage} урон(а)");
            Health -= damage;
        }

        public void TakeRepair()
        {
            Health += 100;
        }

        public virtual void ShowInfo() =>
            Console.WriteLine($"{Name} | {Health}/{MaxHealth} HP");


        public event HealthChangeDeledate? HealthStayedEvent;
        public event HealthChangeDeledate? HealthIncreasedEvent;
        public event HealthChangeDeledate? HealthDecreasedEvent;
    }
}
