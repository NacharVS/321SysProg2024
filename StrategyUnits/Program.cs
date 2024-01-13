using StrategyUnits;

Footman enemy = new Footman();
Footman ally = new Footman();
Peasant peasant = new Peasant();
Healer healer = new Healer();
Altar altar = new Altar("Психушка", 1000);

enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
ally.ShowInfo();

healer.InflictHeal(ally);
ally.ShowInfo();

healer.ShowHealerInfo();

enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
ally.ShowInfo();

healer.InflictHeal(ally);
ally.ShowInfo();

healer.ShowHealerInfo();

Console.WriteLine();

altar.RegenerateStamina(healer);

