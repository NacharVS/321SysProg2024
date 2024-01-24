using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _minDamage;
        private int _maxDamage;

        public MilitaryUnit(string name, int health, int defense, int minDamage, int maxDamage)
        : base(name ,health, defense)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

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

        public virtual void Attack(Unit unit)
        {

            if (this.Health <= 0)
            {
                Console.WriteLine($"Атака не возможна, {this.Name} погиб!");
            }
            else {
                Random random = new Random();

                int a_damage = random.Next(MinDamage, MaxDamage);
                int aa_damage = a_damage - unit.Defense;

                unit.Defense = unit.Defense - a_damage;
                unit.TakeDamage(aa_damage);

                Console.WriteLine($"{unit.Name} получил {a_damage} урона от {this.Name}." +
                    $" Здоровье: {unit.Health}/{unit.MaxHealth}. Защита: {unit.Defense}/{unit.MaxDefense}");
            }    
            if (unit.Health <= 0) Console.WriteLine($"{this.Name} убил {unit.Name}");
           


        }

    }
}
