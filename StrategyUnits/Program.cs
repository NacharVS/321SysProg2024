using StrategyUnits;

Barracks obama = new Barracks();
Footman footman = obama.CreateFootman();
Footman footman2 = obama.CreateFootman();
Berserk guts = obama.CreateBerserk();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();


guts.InflictDamage(footman);
guts.InflictDamage(footman);
footman.InflictDamage(guts);
footman.InflictDamage(guts);
footman.InflictDamage(guts);
footman.InflictDamage(guts);
footman.ShowInfo();
guts.ShowInfo();
guts.InflictDamage(footman);
guts.InflictDamage(footman);
healer1.InflictHeal(guts);
guts.ShowInfo();
footman.InflictDamage(guts);
guts.ShowInfo();
guts.InflictDamage(footman);
