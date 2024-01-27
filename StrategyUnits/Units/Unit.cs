using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Unit : IHealthControl
    {
        public delegate void HealthChangeDeledate(int health, int maxHealth);

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
                    HealthStayedEvent?.Invoke(MaxHealth, MaxHealth);
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

        public Unit(string name, int health)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
        }

        public virtual void ShowInfo() =>
            Console.WriteLine($"{Name} | {Health}/{MaxHealth} HP");

        public virtual void TakeDamage(int damage)
        {
            Console.WriteLine($"{Name} получил {damage} урон(а)");
            Health -= damage;
        }

        public virtual void TakeHeal()
        {
            Console.WriteLine($"{Name} получил +1 хп");
            Health++;
        }

        public event HealthChangeDeledate? HealthStayedEvent;
        public event HealthChangeDeledate? HealthIncreasedEvent;
        public event HealthChangeDeledate? HealthDecreasedEvent;
    }
}
