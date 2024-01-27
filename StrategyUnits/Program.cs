using StrategyUnits;
using StrategyUnits.Units;

internal class Program
{
    private static void Main(string[] args)
    {
        Spawner spawner = new Spawner();
        Barbarian barbarian = spawner.CreateSimpleBarbarian();
        Knight knight = spawner.CreateSimpleKinght();
        Healer healer = spawner.CreateSimpleHealer();
        Knight fool = spawner.CreateFool();
        Priest priest = spawner.CreatePrist();
        #region Scene1
        knight.Attack(barbarian);
        knight.Attack(barbarian);
        barbarian.Attack(knight);
        healer.Healing(barbarian);
        fool.Attack(barbarian);
        knight.Selfheal();
        barbarian.Attack(fool);
        barbarian.Attack(fool);
        healer.Healing(fool);
        priest.ManaRestoring(healer);
        Console.WriteLine(healer.ManaReserve);
        #endregion

    }
}