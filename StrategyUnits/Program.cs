using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();
Altar altar = new Altar();

footman.InflictDamage(ps1);

ps1.ShowInfo();

bishop.Heal(ps1);

ps1.ShowInfo();
bishop.ShowInfo();

altar.RecoveryStamina(bishop);
bishop.ShowInfo();
