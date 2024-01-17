using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();

Healer H1 = new Healer();

ps1.ShowInfo();
footman2.ShowInfo();
//footman.InflictDamage(ps1);
//footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
H1.CauseTreat(ps1);
ps1.ShowInfo();

