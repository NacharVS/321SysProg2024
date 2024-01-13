using StrategyUnits;

Footman footman = new Footman();
//Footman footman2 = new Footman();
Peasant ps1 = new Peasant();

ps1.ShowInfo();
//footman2.ShowInfo();
footman.InflictDamage(ps1);
//footman.InflictDamage(footman2);
ps1.ShowInfo();
//footman2.ShowInfo();

Healer healer1 = new Healer();

healer1.UnitHealing(ps1);
//healer.UnitHealing(footman2);

ps1.ShowInfo();
//footman2.ShowInfo();

Altar altar1 = new Altar();
altar1.MannaHealing(healer1);
altar1.MannaHealing(healer1);
altar1.MannaHealing(healer1);
altar1.MannaHealing(healer1);
