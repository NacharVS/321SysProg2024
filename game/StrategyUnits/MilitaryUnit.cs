using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : unit
    {
        private int _minDamage;
        private int _maxDamage;
        Random random = new Random();

        public MilitaryUnit(int health, string? name, int min, int max, int defense) : base(health, name, defense)
        {
            _minDamage = min;
            _maxDamage = max;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }


        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public void InfictDamage (unit unit)
        {
            int countdamage = random.Next(MinDamage, MaxDamage);
            countdamage -= unit.Defense;
            unit.Health = Math.Max(0, countdamage);
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"unit: {Name} Health: {Health} MaxHealth: {MaxHealth} MaxDamage: {MaxDamage} MinDamage {MinDamage} Defense: {Defense}");
        }
    }
}
