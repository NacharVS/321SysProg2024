﻿using System.Xml.Linq;

namespace StrategyUnits.MilitaryUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(string name, int health, int defense, int minDamage, int maxDamage) : base(name, health, defense, minDamage, maxDamage)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense}");
        }
    }
}
