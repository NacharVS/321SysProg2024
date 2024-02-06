﻿using StrategyUnits;


var casern = new Casern();
var churh = new Church();

var footmat = casern.CreateFootman();
var healer = churh.CreateHealer();
var palladin = churh.CreatePaladin();
var berserker = casern.CreateBerserker();



palladin.HealthDecreasedEvent += LossOfHealth;
palladin.HealthIncreasedEvent += HealthIsRestored;

footmat.HealthDecreasedEvent += LossOfHealth;
footmat.HealthIncreasedEvent += HealthIsRestored;

healer.HealthDecreasedEvent += LossOfHealth;
healer.HealthIncreasedEvent += HealthIsRestored;

berserker.HealthDecreasedEvent += LossOfHealth;
berserker.HealthIncreasedEvent += HealthIsRestored;

footmat.Attack(berserker);
footmat.Attack(berserker);
footmat.Attack(berserker);
footmat.Attack(berserker);
footmat.Attack(berserker);
footmat.Attack(berserker);
berserker.Attack(footmat);
berserker.Attack(palladin);

healer.Healing(palladin);
healer.ShowInfo();

churh.RecoveryManna(healer);

healer.ShowInfo();

static void LossOfHealth(string? name, double health, double difference, double maxHealth)
{
    Console.WriteLine($"{name} получил урон, текущее здоровье: {health}/{maxHealth}, здоровье уменьшилось на {difference}");
}

static void HealthIsRestored(string? name, double health, double difference, double maxHealth)
{
    Console.WriteLine($"{name} был излечён, текущее здоровье: {health}/{maxHealth}, здоровье увеличилось на {difference}");
}