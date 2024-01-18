namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(string? name, int health, int damage) : base(health, name)
        {
            _damage = damage;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }







        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{_damage}");
        }

    }
}
