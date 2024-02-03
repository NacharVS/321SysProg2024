
namespace StrategyUnits.Type
{
    internal class magicUnit : militaryUnits
    {
        private int _mana;
        public int MaxMana { get; private set; }
        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
        public magicUnit(int health, string? name, int defence, int mana, int min_damage, int max_damage) : base(health, name, defence, min_damage, max_damage)
        {
            Mana = mana;
            MaxMana = mana;
        }
    }
}
