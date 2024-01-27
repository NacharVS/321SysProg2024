using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Unit
{
    internal class Knight : IHealthControl, IBattleUnit, IManaControl, IProtectedUnit
    {
        public Knight() 
        {
            Name = "Knight";
            MaxHealth = 40;
            Health = 40;
            MaxMana = 15;
            Mana = 15;
            Armor = 3;
            MinDamage = 4;
            MaxDamage = 8;
            IsDead = false;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Name { get; set; }
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
            damage -= Armor;
            if (damage <= 0) Console.WriteLine($"{Name} получил удар без какого-либо урона");
            else Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"Юнит {Name} умер.");
                IsDead = true;
            }
            else Console.WriteLine($"Юнит {Name} получил {damage + Armor} урона (Поглощено: {Armor}). Тек. здоровье: {Health}/{MaxHealth}");
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }

        public void SelfHeal()
        {
            if (!IsDead)
            {
                if (Mana < 5) Console.WriteLine($"У {Name} не хватает маны на самолечение. (Тек. кол-во Маны: {Mana})");
                else if (Health > 35) Console.WriteLine($"У {Name} и так много здоровья. (Тек. кол-во Маны: {Mana})");
                else
                {
                    Mana -= 5; Health += 5;
                    Console.WriteLine($"{Name} успешно вылечил себя (Здоровье: {Health}/{MaxHealth}, Мана: {Mana})");
                }
            }
            else Console.WriteLine($"Не смотря на божье благославление, {Name} не успел себе помочь...");
        }
    }
}
