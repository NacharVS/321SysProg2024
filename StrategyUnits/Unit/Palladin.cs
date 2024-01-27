using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Unit
{
    internal class Palladin : IBattleUnit, IHealthControl, IManaControl, IProtectedUnit
    {
        public Palladin()
        {
            Name = "Palladin";
            MaxHealth = 50;
            Health = 50;
            MaxMana = 20;
            Mana = 20;
            Armor = 2;
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
            ExcorcismCheck();
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
                if (Mana < 5) Console.WriteLine($"У Палладина не хватает маны на самолечение. (Тек. кол-во Маны: {Mana})");
                else if (Health > 45) Console.WriteLine($"У Палладина и так много здоровья. (Тек. кол-во Маны: {Mana})");
                else
                {
                    Mana -= 5; Health += 5;
                    Console.WriteLine($"Палладин успешно вылечил себя (Здоровье: {Health}/{MaxHealth}, Мана: {Mana})");
                }
            }
            else Console.WriteLine("Не смотря на божье благославление, Палладин не успел себе помочь...");
        }

        public void ExcorcismCheck()
        {
            if (Health < MaxHealth / 2 && Armor == 2)
            {
                Armor *= 2;
            }
            else if (Health > MaxHealth / 2 && Armor == 4)
            {
                Armor /= 2;
            }
        }

        public void SaintRow(IHealthControl unit)
        {
            if (IsDead) Console.WriteLine("И пусть у вас всё ещё протекают трупные спазмы, вряд ли вы сможете кого-то ударить.");
            else
            {
                if (unit.IsDead)
                    Console.WriteLine($"Юнит {unit.Name} уже умер.");
                else
                {
                    Console.WriteLine($"Палладин атакует юнита {unit.Name} священным лучом!");
                    unit.TakeDamage(Mana * 2);
                    Mana = 0;
                }
            }
        }
    }
}
