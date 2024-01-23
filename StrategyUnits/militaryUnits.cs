using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class militaryUnits : Unit
    {
        private int _maxDamage;
        private int _minDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public militaryUnits(int health, string? name, int defense, int minDamage, int maxDamage) : base(health, name, defense)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public void InflictDamage(Unit unit)
        {

            Random rnd = new Random();
            int NewDamage;
            NewDamage = rnd.Next(MinDamage, MaxDamage) - unit.Defense;
            if (NewDamage <= 0)
            {
                Console.WriteLine($"{unit.Name} полуичл 0 урона");
            }
            else
            {
                unit.TakeDamage(NewDamage, unit);
                Console.WriteLine($"{unit.Name} полуичл {NewDamage} урона");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth}");
        }
    }

}
