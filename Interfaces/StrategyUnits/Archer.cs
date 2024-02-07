using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Archer : Unit, IArcher
    {
        public Archer(string? name, double currentHealth, double maxHealth, int countArrow, double arrowDamage) : base(name, currentHealth, maxHealth)
        {
            CountArrow = countArrow;
            ArrowDamage = arrowDamage;
        }

        public int CountArrow { get; set; }
        public double ArrowDamage { get; set; }
        public void ShootArrow(IHealth unit)
        {
            if (CountArrow > 0)
            {
                unit.Health -= ArrowDamage;
                CountArrow--;
            }
            else
            {
                Console.WriteLine(Name + " arrows 0");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон стрел: {ArrowDamage}\nКоличество стрел: {CountArrow}");
        }
    }


}
