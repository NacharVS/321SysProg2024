using StrategyUnits;
using StrategyUnitsSemenov;
using System;

class Program
{
    static void Main()
    {
        // Создаем экземпляры персонажей
        Footman footman1 = new Footman();
        Archer archer = new Archer();
        Berserker berserker = new Berserker();
        Paladin paladin = new Paladin();
        Bishop bishop = new Bishop(); 
        Peasant peasant = new Peasant();

        // Персонажи атакуют и лечат друг друга
        Console.WriteLine("Initial State:");
        ShowCharactersInfo(footman1, archer, berserker, paladin, bishop, peasant);

        Console.WriteLine("\nActions:");

        // Персонажи атакуют
        footman1.InflictDamage(peasant);
        archer.Shoot(berserker);
        berserker.Attack(archer);

        // Персонажи лечат
        paladin.Heal(bishop);
        bishop.Heal(berserker); 

        Console.WriteLine("\nUpdated State:");
        ShowCharactersInfo(footman1, archer, berserker, paladin, bishop, peasant);
    }

    static void ShowCharactersInfo(params Unit[] units)
    {
        foreach (var unit in units)
        {
            unit.ShowInfo();
        }
    }
}
