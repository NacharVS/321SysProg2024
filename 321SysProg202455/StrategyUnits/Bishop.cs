using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        public Bishop() : base(30, "Bishop", 0, 1, 2, 15, 100)
        {
        }

        public void HealUnit(Unit unit)
        {
            if (unit.Health == 0)
                return;

            if (unit.MaxHealth - unit.Health > HealStrange)
            {
                if (Mana < HealStrange && Mana != 0)
                {
                    unit.Health += Mana;
                    Mana = 0;
                }
                else if (Mana > HealStrange)
                {
                    unit.Health += HealStrange;
                    Mana -= HealStrange;
                }
            }
            else if (unit.MaxHealth - unit.Health < HealStrange && unit.MaxHealth - unit.Health != 0)
            {
                if (Mana < unit.MaxHealth - unit.Health && Mana != 0)
                {
                    unit.Health += Mana;
                    Mana = 0;
                }
                else if (Mana > unit.MaxHealth - unit.Health)
                {
                    Mana -= unit.MaxHealth - unit.Health;
                    unit.Health = unit.MaxHealth;
                }
            }
        }

        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Волшебник нанесн ударом посоха {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
    }
}
