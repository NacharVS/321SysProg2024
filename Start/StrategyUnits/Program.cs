using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Berserker b1 = new Berserker();
Healer healer = new Healer();
Archer archer = new Archer(20);
Palladin palladin = new Palladin();

ps1.ShowInfo();
ps1.goWork();
ps1.goWork();

footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
palladin.MagicHit(archer);
archer.ShootArrow(footman);
footman.ShowInfo();

b1.HeavyBlow(palladin);
b1.HeavyBlow(archer);
palladin.ShowInfo();
archer.ShowInfo();
palladin.ShowInfo();
