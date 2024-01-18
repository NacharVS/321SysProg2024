using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base(30, "Healer", 0, 1, 3, 30)
        {
            _heal = 1;
        }

        private int _heal;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public void InflictHeal(Unit unit)
        {
            int HealthBefore = unit.Health;
            while (Mana != 0 && unit.Health < unit.MaxHealth)
            {
                unit.Health += _heal;
                Mana -= 2;
            }
            Console.WriteLine($"Лекарь восстановил юниту {unit.Name} {unit.Health - HealthBefore} здоровья, затратив {(unit.Health - HealthBefore) * 2} маны");
        }
    }
}
