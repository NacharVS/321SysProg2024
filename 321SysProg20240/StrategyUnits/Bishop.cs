using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit, IManaController, IDamageController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _mana;
        private int _maxMana;
        private int _healStrange;
        public Bishop(int health, string name, int healStrange, int mindamage, int maxdamage, int mana)
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _healStrange = healStrange;
            _maxMana = mana;
            _mana = mana;
        }

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value >= _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }
        public int HealStrange { get => _healStrange; set => _healStrange = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }

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

        public void Attack(Unit unit)
        {
            if (unit.Health <= 0 && Health <= 0)
                return;
            int damage = new Random().Next(_minDamage, _maxDamage);
            Console.WriteLine($"Волшебник нанесн ударом посоха {damage} урона Юниту: {Name}");
            unit.TakeDamage(damage);
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Лекарь (Элина):\r\n" +
                "Элина, обладая исцеляющими руками, стояла на передовой жизни и смерти. \n" +
                "Ее лечебные зелья и заживляющие слова восстанавливали и вдохновляли союзников. \n" +
                "Она была надеждой армии, ограждая их от теней смерти.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    current mana: {Mana} / {_maxMana}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
