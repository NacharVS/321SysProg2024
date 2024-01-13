using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar altar1 = new Altar();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
healer1.ShowInfo();
healer1.ShowMainInfo();
healer1.AddHeal(ps1);
healer1.ShowMainInfo();
altar1.AddManaToUnit(healer1);
ps1.ShowInfo();
