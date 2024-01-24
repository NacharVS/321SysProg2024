using StrategyUnits;

Barracks obama = new Barracks();
Footman footman = obama.CreateFootman();
Footman footman2 = obama.CreateFootman();
Berserk guts = obama.CreateBerserk();
Palladin Maxon = obama.CreatePalladin();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();

guts.HealthDecreasedEvent += GiveRageEvent;
guts.HealthIncreasedEvent += TakeRageEvent;
Maxon.HealthDecreasedEvent += ExorcismEvent;
Maxon.HealthIncreasedEvent += UnExorcismEvent;

Maxon.InflictDamage(footman);
Maxon.InflictDamage(footman);
footman.InflictDamage(Maxon);
footman.InflictDamage(Maxon);
footman.InflictDamage(Maxon);
footman.InflictDamage(Maxon);
footman.InflictDamage(Maxon);
footman.InflictDamage(Maxon);
footman.ShowInfo();
Maxon.ShowInfo();
Maxon.InflictDamage(footman);
Maxon.InflictDamage(footman);
healer1.ShowInfo();
healer1.InflictHeal(Maxon);
healer1.ShowInfo();
Maxon.ShowInfo();
footman.InflictDamage(Maxon);
Maxon.ShowInfo();
Maxon.InflictDamage(footman);
Maxon.ShowInfo();
Maxon.SelfHeal();
Maxon.ShowInfo();

//guts.InflictDamage(footman);
//guts.InflictDamage(footman);
//footman.InflictDamage(guts);
//footman.InflictDamage(guts);
//footman.InflictDamage(guts);
//footman.ShowInfo();
//guts.ShowInfo();
//guts.InflictDamage(footman);
//guts.InflictDamage(footman);
//healer1.InflictHeal(guts);
//guts.ShowInfo();
//footman.InflictDamage(guts);
//guts.ShowInfo();
//guts.InflictDamage(footman);
//guts.ShowInfo();
//guts.ShowInfo();



static void GiveRageEvent(Unit unit)
{
    Berserk berserk = (Berserk)unit;
    if (unit.Name == "Berserk" && berserk.Health <= berserk.MaxHealth/2 && berserk.MinDamage == 3)
    {
        berserk.MinDamage *= 2;
        berserk.MaxDamage *= 2;
    }
    return;
}

static void TakeRageEvent(Unit unit)
{
    Berserk berserk = (Berserk)unit;
    if (unit.Name == "Berserk" && unit.Health > unit.MaxHealth / 2 && berserk.MinDamage == 6)
    {
        berserk.MinDamage /= 2;
        berserk.MaxDamage /= 2;
    }
    return;
}

static void ExorcismEvent(Unit unit)
{
    Palladin palladin = (Palladin)unit;
    if (palladin.Name == "Palladin" && palladin.Health <= palladin.MaxHealth / 2 && palladin.Armor == 5)
        palladin.Armor *= 2;
    return;
}

static void UnExorcismEvent(Unit unit)
{
    Palladin palladin = (Palladin)unit;
    if (palladin.Name == "Palladin" && palladin.Health > palladin.MaxHealth / 2 && palladin.Armor == 10)
        palladin.Armor /= 2;
    return;
}