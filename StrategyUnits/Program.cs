using StrategyUnits;

Barracs barracs = new Barracs();
Footman footman = barracs.CreateSuperFootman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Palladin pl = new Palladin();
Altar al = new Altar();

ps1.HealthIncreaseEvent += MethodHeal;
ps1.HealthDecreaseEvent += MethodUnHeal;
pl.InflictDamage(ps1);
ps1.ShowInfo();
healer1.AddHeal(ps1);
healer1.ShowInfo();
al.AddManaToUnit(healer1);
healer1.ShowInfo();
ps1.ShowInfo();
footman.InflictDamage(ps1);

static void MethodHeal(int number)
{
    Console.WriteLine($"Health has added. Current: {number}");
}
static void MethodUnHeal(int number)
{
    Console.WriteLine($"Health has disadded. Current: {number}");
}


