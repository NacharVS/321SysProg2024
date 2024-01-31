using System;

namespace StrategyUnits
{
    class Program
    {
        static void Main()
        {
            
            Barak barak = new Barak();
            Footman footman = barak.CreateFootman();
            Bishop bishop = barak.CreateBishop();
            Altar altar = new Altar();
            Berserk berserker = barak.CreateBerserk();
            Knight knight = barak.CreateKnight();
            Peasant peasant = new Peasant();
            Archer archer = barak.CreateArcher();
            Paladin palladin = barak.CreatePalladin();
            
                      
            berserker.ChageIncreaseHealth += IncreseHealth;
            berserker.ChageDecreaseHealth += DecreseHealth;
            knight.ChageIncreaseHealth += IncreseHealth;
            knight.ChageDecreaseHealth += DecreseHealth;
            footman.ChageIncreaseHealth += IncreseHealth;
            footman.ChageDecreaseHealth += DecreseHealth;
            palladin.ChageIncreaseHealth += IncreseHealth;
            palladin.ChageDecreaseHealth += DecreseHealth;

            
        }
        static void IncreseHealth(int health, string? name, int maxhealth)
        {

            Console.Write($"Вылечили здоровье. \n" +
                $"Юнит: {name} Текущее здоровье: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{health}/{maxhealth}");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void DecreseHealth(int health, string? name, int maxhealth)
        {
            if (health <= 0)
                return;
            
            else
            {
                Console.Write($"Нанесли урон. Юнит: {name} Текущее здоровье: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{health}/{maxhealth}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }

}


