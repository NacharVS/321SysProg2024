using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Archer : MilitaryUnit
    {
        private int _arrows_count;

        public Archer(int health, string? name, double protection, double damage, int arrowsCount) : base(health, name, protection, damage)
        {
            _arrows_count = arrowsCount;
        }

        public void ShootArrow(Unit unit)
        {
            if (_arrows_count > 0)
            {
                if (Protection > Damage)
                {
                    unit.Health -= 0;
                }
                else
                {
                    unit.Health -= this.Damage - Protection;
                    _arrows_count--;
                }
                    
            }
            else
            {
                Console.WriteLine(this.Name + " arrows 0");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон стрел: {Damage}\nКоличество стрел: {_arrows_count}");
        }
    }
}
