using System;

namespace StrategyUnits
{
    class Program
    {
        static void Main()
        {
            Barak barak = new Barak();
            Footman footman = barak.CreateAdvansedFootman();
            Footman footman2 = barak.CreateRecruitFootman();
            Bishop bishop = new Bishop();
            Altar altar = new Altar();
            Footman berserker = barak.CreateBerserk();
            Knight knight = barak.CreateKnight();
            
            footman2.ChageIncreaseHealth += IncreseHealth;
            footman2.ChageDecreaseHealth += DecreseHealth;
            berserker.ChageIncreaseHealth += IncreseHealth;
            berserker.ChageDecreaseHealth += DecreseHealth;
            knight.ChageIncreaseHealth += IncreseHealth;
            knight.ChageDecreaseHealth += DecreseHealth;
            footman.ChageIncreaseHealth += IncreseHealth;
            footman.ChageDecreaseHealth += DecreseHealth;


            footman.Attack(footman2);
            footman.Attack(footman2);
            footman.Attack(footman2);
            footman.Attack(footman2);
            footman.Attack(footman2);
            bishop.HealUnit(footman2);
            

        }
        static void IncreseHealth(int health, int maxhealth, string? name, int armor)
        {
            Console.WriteLine($"Юнит: {name} Текущее здоровье: {health}/{maxhealth} Armor:{armor} ");
        }
        static void DecreseHealth(int health, int maxhealth, string? name, int armor)
        {
            Console.WriteLine($"Юнит: {name} Текущее здоровье: {health}/{maxhealth} Armor:{armor}");
        }
    }

}


