using StrategyUnits;

Barracs barracs = new Barracs();
Footman ft1 = barracs.CreateSuperFootman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar al = new Altar();
Footman ft = barracs.CreateSuperFootman();
Knight kn = barracs.CreateKnight();
Berserker bs = barracs.CreateBerserk();
Palladin pl = barracs.CreatePalladin();

////done 
//bs.HealthIncreaseEvent += MethodHeal;
//bs.HealthDecreaseEvent += MethodUnHeal;
//ps1.ShowInfo();
//healer1.AddHeal(ps1);
//healer1.ShowInfo();
//al.AddManaToUnit(healer1);
//healer1.ShowInfo();
//ps1.ShowInfo();
//ft1.InflictDamage(ps1);


////test
//bs.InflictDamage(kn);
//kn.ShowInfo();
//kn.SelfHeal();
//kn.ShowInfo();
//pl.ScintRow(kn);
//healer1.ShowInfo();
//pl.Exorcizm(healer1);
//healer1.ShowInfo();


bs.InflictDamage(pl);
pl.ScintRow(kn);
kn.ShowInfo();
kn.SelfHeal();
bs.ShowInfo();
healer1.AddHeal(bs);
bs.InflictDamage(pl);

pl.ScintRow(bs);
bs.InflictDamage(pl);

static void MethodHeal(int number)
{
    Console.WriteLine($"Health has added. Current: {number}");
}
static void MethodUnHeal(int number)
{
    Console.WriteLine($"Health has disadded. Current: {number}");
}


