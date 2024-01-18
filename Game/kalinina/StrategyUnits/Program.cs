using StrategyUnits;


Peasant peasant1 = new Peasant();
Footman footman1 = new Footman();
Archer archer1 = new Archer();
Berserker berserker1 = new Berserker();
Healer Healer1  = new Healer();
Pallagin pallagin1 = new Pallagin();
Teample teample1= new Teample();

peasant1.ShowInfo();
archer1.InfictDamage(peasant1);
archer1.InfictDamage(peasant1);
peasant1.ShowInfo();
Healer1.ShowInfo();
Healer1.CauseTreat(peasant1);
Healer1.CauseTreat(peasant1);
peasant1.ShowInfo();
Healer1.ShowInfo();
teample1.Addenergy(Healer1);
Healer1.ShowInfo();








