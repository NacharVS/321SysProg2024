using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private double _damage;

        public MilitaryUnit(int health, string? name, double protection, double damage) : base(health, name, protection)
        {
            _damage = damage;
        }

        public double Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamage(Unit unit)
        {
            if (unit.Protection > Damage)
            {
                unit.Health -= 0;
            }
            else
            {
                unit.Health -= _damage - unit.Protection;
            }
        }
    }
}
