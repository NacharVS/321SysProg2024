using StrategyUnits;
using System.Security.Cryptography;

//Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Barracks barracks = new Barracks();
Footman footman = barracks.CreateFootman();
Healer healer = barracks.CreateHealer();
Bersercer bersercer = barracks.CreateBersercer();
Paladin paladin = barracks.CreatePalladin();


ps1.ShowInfo();
//footman2.ShowInfo();
footman.Attack(ps1);
//footman.InflictDamage(footman2);
footman.Attack(bersercer);
footman.Attack(bersercer);
footman.Attack(bersercer);
footman.Attack(bersercer);
bersercer.Attack(ps1);
footman.Attack(bersercer);
bersercer.Attack(paladin);
bersercer.Attack(paladin);

bersercer.Attack(ps1);
bersercer.Attack(ps1);

Knight knight = barracks.CreateKnight();
bersercer.Attack(knight);

knight.SelfHeal();
Altar altar1 = new Altar();
Console.WriteLine("ShowInfo:");

footman.ShowInfo();
bersercer.ShowInfo();
healer.ShowInfo();
knight.ShowInfo();
paladin.ShowInfo();
//healer.UnitHealing(ps1);
//healer.UnitHealing(footman2);


//footman2.ShowInfo();


//altar1.MannaHealing(healer);
//altar1.MannaHealing(healer);
//altar1.MannaHealing(healer);
