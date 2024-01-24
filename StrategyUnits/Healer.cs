using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer(int health, string? name, int armor, int minDamage, int maxDamage, int mana) : base(health, name, armor, minDamage, maxDamage, mana)
        {
            _heal = 2;
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
                Mana -= 1;
            }
            Console.WriteLine($"Лекарь восстановил юниту {unit.Name} {unit.Health - HealthBefore} здоровья, затратив {(unit.Health - HealthBefore) / 2} маны");
        }
    }
}
