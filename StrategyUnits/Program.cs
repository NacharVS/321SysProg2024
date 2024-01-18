using StrategyUnits;

Barracs barracs = new Barracs();
Footman footman = barracs.CreateRecruitFootman();
Footman footman2 = barracs.CreateVeteranFootman();


Peasant ps1 = new Peasant();

ps1.HealthChangedEvent += Method;


footman2.ShowInfo();
footman.ShowInfo();


static void Method(int number)
{
    Console.WriteLine($"Health has changed. Current: {number}");
}
