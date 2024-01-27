using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Palladin : MagicUnit, IProtectionControl
    {
        public int Protection { get; set; }
        public Palladin(string name, int health, int damage, int protection, int mana) : base(name, health, damage, mana)
        {
            Protection = protection;
        }

        public override void TakeDamage(int damage)
        {
            if (Health > 0 && Health <= MaxHealth * 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (damage < Protection * 2) 
                {
                    Console.WriteLine("*Бронер Бытер Иннер Зезер Активетер*");
                    Console.WriteLine($"Броня сдержала весь урон {damage}");
                }
                else
                {
                    Console.WriteLine("*Бронер Бытер Иннер Зезер Активетер*");
                    Console.WriteLine($"Броня сдержала {Protection * 2} урон(а). {Name} получил {damage - Protection * 2} урон(а)");
                    Health -= damage - Protection * 2;
                }         
                Console.ResetColor();

            }
            else
            {
                base.TakeDamage(damage);
            }
        }

        public void SelfHeal()
        {
            while (Mana >= 2)
            {
                if (Health <= 0 || Health >= MaxHealth * 0.5)
                {
                    Console.WriteLine("Я не могу отхилиться");
                    return;
                }

                Mana -= 2;

                Health++;
            }
            Console.WriteLine("Это все");
        }

        public override void ShowInfo() =>
            Console.WriteLine($"{Name} | {Health}/{MaxHealth} HP | {Protection} PP | {Mana}/{MaxMana} MP");
    }
}
