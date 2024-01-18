using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar altar1 = new Altar();


ps1.ShowInfo();
footman2.ShowInfo();
ps1.TakeDamage(footman);
ps1.TakeDamage(footman);
ps1.ShowInfo();
ps1.TakeHeal(healer1);
ps1.ShowInfo();
healer1.ShowInfo();
altar1.Recovery(healer1);
altar1.Recovery(healer1);
altar1.Recovery(healer1);
healer1.ShowInfo();



