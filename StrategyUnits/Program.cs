using StrategyUnits;

internal class Program
{
    private static void Main(string[] args)
    {
        Barracs barracs = new Barracs();
        MagicPortal magicPortal = new MagicPortal();
        Palladin knight = magicPortal.CreateMiddleKnight();
        Footman berserk = barracs.CreateBerserk();
        Healer healer = magicPortal.CreateMiddleHelaer();

        knight.TakeDamage(berserk);
        knight.TakeDamage(berserk);
        knight.ShowInfo();
        berserk.ShowInfo();
        berserk.TakeDamage(knight);
        berserk.ShowInfo();
        berserk.TakeHeal(healer);
        knight.SelfHeal();
        knight.ShowInfo();
        berserk.ShowInfo();

    }
}