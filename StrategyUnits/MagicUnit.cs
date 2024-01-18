namespace StrategyUnits
{
    internal class MagicUnit : MilliUnit
    {
        private int _healthValue;

        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }
        public MagicUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
        }
    }
}
