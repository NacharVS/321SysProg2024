namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        private int _magic_damage;

        public int Manna
        {
            get { return _manna; }
            set { _manna = value; }
        }

        public int MagicDamage
        {
            get { return _magic_damage; }
            set { _magic_damage = value; }
        }

        public MagicUnit(int health, int manna, string? name, int magic_damage, int damage) : base(0, "", 0)
        {
            Health = health;
            Manna = manna;
            Name = name;
            MaxHealth = health;
            MagicDamage = magic_damage;
            Damage = damage;
        }
    }
}
