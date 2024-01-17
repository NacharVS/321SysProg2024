using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar altar1 = new Altar();


ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
healer1.HealHP(ps1);
ps1.ShowInfo();
healer1.ShowInfo();
altar1.Recovery(healer1);
altar1.Recovery(healer1);
altar1.Recovery(healer1);
healer1.ShowInfo();



