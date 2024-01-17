using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Palladin pl = new Palladin();

pl.InflictDamage(ps1);
ps1.ShowInfo();
healer1.AddHeal(ps1);
ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);

