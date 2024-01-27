namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string name, int armor, int mindamage, int maxdamage)
            : base(health, name, armor, mindamage, maxdamage)
        {
        }


        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Пехотинец нанес ударом дубины {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
    }
}
