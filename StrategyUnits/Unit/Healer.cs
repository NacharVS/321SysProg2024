using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : IBattleUnit, IHealthControl, IManaControl, IUnitAbleToHeal
    {
        public Healer()
        {
            Name = "Healer";
            MaxHealth = 30;
            Health = 30;
            MinDamage = 1;
            MaxDamage = 5;
            MaxMana = 30;
            Mana = 30;
            Heal = 2;
            IsDead = false;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public int Heal { get; set; }
        public bool IsDead { get; set; }

        public void Attack(IHealthControl unit)
        {
            if (IsDead) Console.WriteLine("И пусть у вас всё ещё протекают трупные спазмы, вряд ли вы сможете кого-то ударить.");
            else
            {
                if (unit.IsDead)
                    Console.WriteLine($"Юнит {unit.Name} уже умер.");
                else
                {
                    Random rnd = new Random();
                    int damage;
                    damage = rnd.Next(MinDamage, MaxDamage);
                    Console.WriteLine($"Юнит {Name} атакует юнита {unit.Name}");
                    unit.TakeDamage(damage);
                }
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"Юнит {Name} умер.");
                IsDead = true;
            }
            else Console.WriteLine($"Юнит {Name} получил {damage} урона. Тек. здоровье: {Health}/{MaxHealth}");
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health > MaxHealth)
                Health = MaxHealth;
            else Console.WriteLine($"Юнита {Name} уже не спасти...");
        }

        public void InflictHeal(IHealthControl unit)
        {
            if (IsDead)
                Console.WriteLine($"Лекарь лечил других так много, что не успел спасти себя...");
            else
            {
                if (unit.IsDead) Console.WriteLine($"Юнита {unit.Name} уже не спасти...");
                else
                {
                    int HealthBefore = unit.Health;
                    int ManaBefore = Mana;
                    while (Mana != 0 && unit.Health < unit.MaxHealth)
                    {
                        unit.TakeHeal(Heal);
                        Mana -= 1;
                    }
                    Console.WriteLine($"Лекарь восстановил юниту {unit.Name} {unit.Health - HealthBefore} здоровья, затратив {ManaBefore - Mana} маны (Осталось: {Mana})");
                    Console.WriteLine($"Юнит: {unit.Name}. Здоровье: {unit.Health}/{unit.MaxHealth}");
                }
            }
            
        }
    }
}
