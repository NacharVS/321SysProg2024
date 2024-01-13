using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Wizard wizard = new Wizard();
Temple temple = new Temple();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1); 
footman.InflictDamage(ps1);
ps1.ShowInfo();
wizard.InflictTreat(ps1);
wizard.ShowInfo();
ps1.ShowInfo();
temple.ShowInfo();
temple.InflictMAna(wizard);
temple.ShowInfo();
wizard.ShowInfo();