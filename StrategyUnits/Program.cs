using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();

ps1.HealthChangedEvent += Method;


ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();


static void Method(int number)
{
    Console.WriteLine($"Health has changed. Current: {number}");
}
