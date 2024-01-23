using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Knight : magicUnit
    {
        private int _heal;
        public Knight(int health, string? name, int defence, int mana, int min_damage, int max_damage) : base(health, name, defence, mana, min_damage, max_damage)
        {
            _heal = 1;
        }
        public void SelfHeal()
        {
            Console.WriteLine("Лечимся!");
            while (this.Health < this.MaxHealth && Mana > 0)
            {
                if (this.Health + 1 >= this.MaxHealth)
                {
                    this.Health = this.MaxHealth;
                    this.HealDamage(Health);
                    Console.WriteLine("Вылечен!");
                }
                else
                {
                    this.Health += _heal;
                    Mana -= 2;
                    if (Mana < 0)
                    {
                        Console.WriteLine("Нет маны!");
                    }
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Рыцарь {Health}/{MaxHealth}");
        }
    }
}
