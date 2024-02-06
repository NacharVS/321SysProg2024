namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public MilitaryUnit(int health, string? name, int damage) : base(0, "")
        {
            Health = health;
            Name = name;
            MaxHealth = health;
            Damage = damage;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
    }
}
