namespace StrategyUnits
{
    internal class Altar : Build
    {
        private int _staminaAdd;
        public Altar() : base(1200, "Poliklinika")
        {
            _staminaAdd = 30;
        }
        public void Recovery(Unit unit)
        {
            unit.Stamina += _staminaAdd;
        }
    }
}
