using StrategyUnits;
using System;

Obama obama = new Obama();
Footman footman = obama.CreateFootman();
Footman footman1 = obama.CreateBerserk();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();
Altar altar1 = new Altar();

footman1.ActivateRageEvent += Rage;

static void Rage(int health)
{
}

ps1.ShowInfo();
footman1.ShowInfo();
footman1.TakeDamage(footman);
footman1.ShowInfo();
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



