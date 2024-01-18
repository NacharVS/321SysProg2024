using StrategyUnits;

Barracs barracs = new Barracs();
Footman ft1 = barracs.CreateSuperFootman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar al = new Altar();

//done 
ps1.HealthIncreaseEvent += MethodHeal;
ps1.HealthDecreaseEvent += MethodUnHeal;
ps1.ShowInfo();
healer1.AddHeal(ps1);
healer1.ShowInfo();
al.AddManaToUnit(healer1);
healer1.ShowInfo();
ps1.ShowInfo();
ft1.InflictDamage(ps1);

//test
ft1 = GetBers();
ft1.ShowInfo();

 void GetBers()
{
    barracs.CreateBerserk();
}
static void MethodHeal(int number)
{
    Console.WriteLine($"Health has added. Current: {number}");
}
static void MethodUnHeal(int number)
{
    Console.WriteLine($"Health has disadded. Current: {number}");
}


