using System.Xml.Linq;

namespace StrategyUnits.MilitaryUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(string name) : base(name, 60, 5, 3, 10) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense}");
        }
    }
}
