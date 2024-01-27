using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class Unit : IHealthControll
    {
        private int _health;
        private int _maxHealth;
        private bool _isAlive = true;

        public string Name { get; set; }

        public bool IsAlive { get { return _isAlive; } }
        public int Health
        {
            get { return _health; }
            set
            {
                if (value < IHealthControll.minHealth)
                {
                    _health = IHealthControll.minHealth;
                    _maxHealth = IHealthControll.minHealth;
                }
                else
                    _health = value;
                _health = Math.Min(Math.Max(value, 0), MaxHealth);
                if (value <= 0)
                    _isAlive = false;
                
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
        }

        public Unit(int health, string name)
        {
            _maxHealth = health;
            Name = name;
            Health = health;

        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public virtual void TakeHealth(int heal)
        {
            Health += heal;
        }

    }
}
