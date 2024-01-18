namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(90, "Hrash", 75, 9)
        {
            Heal = 1;
            Damage = 5;
        }
    }
}
