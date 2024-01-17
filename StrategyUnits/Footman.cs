using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman() : base("Болванчик",60,3, 12) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense}");
        }
    }
}
