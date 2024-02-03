using StrategyUnits;
using StrategyUnits.Buildings;
using StrategyUnits.Unit;

Footman f1 = new Footman();
Footman f2 = new Footman();
Healer h1 = new Healer();
Palladin guts = new Palladin();
Knight k1 = new Knight();
Altar altar = new Altar();

guts.SaintRow(f2);
altar.RecoverMana(guts);
guts.SaintRow(f1);
h1.InflictHeal(f1);
