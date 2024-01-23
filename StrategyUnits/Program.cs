using StrategyUnits;

Barracs barracs1 = new Barracs();
Footman footman = barracs1.CreateFootman();
Berserker berserker1 = barracs1.CreateBerserker();
Archer archer1 = barracs1.CreateArcher();
Paladin paladin1 = barracs1.CreatePaladin();
Knight knight1 = barracs1.CreateKnight();
Healer healer1 = barracs1.CreateHealer();
Peasant ps1 = new Peasant();


//berserker1.InflictDamage(footman);
//berserker1.InflictDamage(footman);

//footman.InflictDamage(berserker1);
//footman.InflictDamage(berserker1);
//footman.InflictDamage(berserker1);
//berserker1.InflictDamage(footman);
//berserker1.InflictDamage(footman);
//berserker1.InflictDamage(footman);
//footman.ShowInfo();
//berserker1.ShowInfo();
//healer1.AddHeal(berserker1);
//healer1.AddHeal(berserker1);
//healer1.AddHeal(berserker1);
//footman.ShowInfo();
//berserker1.ShowInfo();
//berserker1.InflictDamage(footman);
//berserker1.InflictDamage(footman);

berserker1.HealthDecreasedEvent += PlusRageEvent;
berserker1.HealthIncreasedEvent += MinusRageEvent;
paladin1.HealthDecreasedEvent += ExorcismEvent;
paladin1.HealthIncreasedEvent += NotExorcismEvent;

paladin1.InflictDamage(footman);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.InflictDamage(paladin1);
footman.ShowInfo();
paladin1.ShowInfo();


/////////////////////////////////////////////
static void PlusRageEvent(Unit unit)
{
    Berserker berserker = (Berserker)unit;
    if (unit.Name == "Berserker" && berserker.Health <= berserker.MaxHealth / 2)
    {
        berserker.MinDamage *= 2;
        berserker.MaxDamage *= 2;

    }
    return;
}

static void MinusRageEvent(Unit unit)
{
    Berserker berserker = (Berserker)unit;
    if(unit.Name == "Berserker" && unit.Health > unit.MaxHealth / 2)
    {
        berserker.MinDamage /= 2;
        berserker.MaxDamage /= 2;

    }
    return;
}

static void ExorcismEvent(Unit unit)
{
    Paladin paladin = (Paladin)unit;
    if (paladin.Name == "Paladin" && paladin.Health <= paladin.MaxHealth / 2)
    {
        paladin.Defense *= 2;

    }
    return;
}

static void NotExorcismEvent(Unit unit)
{
    Paladin paladin = (Paladin)unit;
    if (paladin.Name == "Paladin" && paladin.Health > paladin.MaxHealth / 2)
    {
        paladin.Defense /=2;

    }
    return;
}

