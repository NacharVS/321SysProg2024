using System;

namespace StrategyUnits
{
    class Program
    {
        static void Main()
        {
            Taverna taverna = new Taverna();
            Footman footman = taverna.CreateAdvansedFootman();
            Archer archer = new Archer();
            Bishop bishop = new Bishop();
            Altar altar = new Altar();
            Footman berserk = taverna.CreateBerserk();
            Knight knight = taverna.CreateKnight();

            archer.ChageIncreaseHealth += IncreseHealth;
            archer.ChageDecreaseHealth += DecreseHealth;
            berserk.ChageIncreaseHealth += IncreseHealth;
            berserk.ChageDecreaseHealth += DecreseHealth;
            knight.ChageIncreaseHealth += IncreseHealth;
            knight.ChageDecreaseHealth += DecreseHealth;
            footman.ChageIncreaseHealth += IncreseHealth;
            footman.ChageDecreaseHealth += DecreseHealth;


            berserk.Attack(footman);

            bishop.HealUnit(footman);

            Footman VeteranFootman = taverna.CreateVeteranFootman();
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);
            VeteranFootman.Attack(berserk);



        }
        static void IncreseHealth(int health, int maxhealth, string? name, int armor)
        {
            Console.WriteLine($"Юнит: {name} Здоровье: {health}/{maxhealth} Armor:{armor} ");
        }
        static void DecreseHealth(int health, int maxhealth, string? name, int armor)
        {
            Console.WriteLine($"Юнит: {name} Здоровье: {health}/{maxhealth} Armor:{armor}");
        }
    }

}


