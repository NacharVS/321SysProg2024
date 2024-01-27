using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Altar : IHealthControl
    {
        public Altar() 
        {
            Name = "Altar";
            MaxHealth = 300;
            Health = 300;
            IsDead = false;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} разрушен.");
                IsDead = true;
            }
            else Console.WriteLine($"{Name} получил {damage} урона. Тек. здоровье: {Health}/{MaxHealth}");
        }

        public void TakeHeal(int heal) 
        {
            Health += heal;
            if (Health > MaxHealth)
                Health = MaxHealth;
            else Console.WriteLine($"{Name} уже не спасти...");
        }

        public void RecoverMana(IManaControl unit)
        {
            unit.Mana = unit.MaxMana;
            IHealthControl un = (IHealthControl)unit;
            Console.WriteLine($"Юниту {un.Name} полностью восстановлена мана");
        }
    }
}
