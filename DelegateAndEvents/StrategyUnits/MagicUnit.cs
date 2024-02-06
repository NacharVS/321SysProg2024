namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        private int _maxManna;
        private int _magic_damage;

        public MagicUnit(int health, string? name, double protection, double damage, int manna, int maxManna) : base(health, name, protection, damage)
        {
            _manna = manna;
            _maxManna = maxManna;
        }


        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public int MaxManna
        {
            get { return _maxManna; }
            set { _maxManna = value; }
        }
        public int MagicDamage
        {
            get { return _magic_damage; }
            set { _magic_damage = value; }
        }

    }
}
