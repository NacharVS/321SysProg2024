using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, int armor, int minDamage, int maxDamage) : base(health, name, armor, minDamage, maxDamage) { }
    }
}

