namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {


        public Footman() : base(60, "Footman",2, 3, 7)
        {

        }

        public override void Attack(Unit unit)
        {
            Console.Write("Пехотинец нанес дубиной ");
            base.Attack(unit);
        }
    }
}
