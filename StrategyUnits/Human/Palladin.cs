using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Type;

namespace StrategyUnits.Human
{
    internal class Palladin : Knight
    {
        private int _comboFight;
        public Palladin(int health, string? name, int defence, int mana, int min_damage, int max_damage) : base(health, name, defence, mana, min_damage, max_damage)
        {
        }
        public void ScintRow(Unit unit)
        {
            _comboFight = 0;
            Console.WriteLine("Башка сломат режим вкл.");
            while (_comboFight < 5)
            {
                InflictDamage(unit);
                _comboFight++;
            }
            Console.WriteLine("Башка сломат режим выкл.");
        }
        public void Exorcizm(magicUnit magicUnit)
        {
            Console.WriteLine("Напитки из черноголовки");
            magicUnit.Mana -= 2;
            Mana += 2;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Паладин {Health}/{MaxHealth}");
        }
    }
}
