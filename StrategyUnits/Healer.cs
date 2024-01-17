using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Healer : magicUnit
    {
        private int _heal;

        public int Heal { 
            get { return _heal; }
            set { _heal = value; }
        }
        
        public Healer() : base(50, "Healer", 0, 30, 2, 5)
        {
            _heal = 1;
        }
        public void AddHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth && Mana>0)
            {
                if (unit.Health+1 >= unit.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                    unit.HealDamage(Health);
                    Console.WriteLine($"{this.Name} вылечил {unit.Name}");
                }
                else
                {
                    unit.Health += _heal;
                    Mana -= 2;
                }
            }
            Console.WriteLine("Юнит здоров либо нет маны!");

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит:{this.Name} Mana: {Mana}/{MaxMana} Здровье: {Health}/{MaxHealth}");
        }
    }
}
