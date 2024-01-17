namespace StrategyUnitsSemenov
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (unit.Health < 0)
            {
                Console.WriteLine("Health < 0, value setted to 0, Footman.cs");
                unit.Health = 0;
            }

            else
            {
                if (unit.Health < _damage)
                {
                    unit.Health = 0;
                    Console.WriteLine($"Умер - {unit.Name}");
                }
                else
                    unit.Health -= _damage;
            }
        }
    }
}
