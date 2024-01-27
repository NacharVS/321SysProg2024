using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class Healer : Unit, IHealerUnit, IProtectedUnit
    {
        private const int _healerBenefit = 2;
        private const int _healCost = 10;
        public Healer(string name, int health, int defense, int heal, int manaReserve) : base(health, name)
        {
            Defense = defense;
            Heal = heal;
            ManaReserve = manaReserve;
        }

        public int Heal { get; set; }
        public int ManaReserve { get; set; }
        public int Defense { get; set; }

        public void Healing(IHealthControll unit)
        {
            if (ManaReserve < 0)
                ManaReserve = 0;
            while (unit.Health < unit.MaxHealth && ManaReserve >= _healCost)
            {
                unit.TakeHealth(Heal);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} healed {unit.Name} and regenerated {Heal} HP. \n{unit.Name} has {unit.Health} HP.");
                Console.ResetColor();
                ManaReserve -= _healCost;
            }
        }
        public override void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }

        public override void TakeHealth(int heal)
        {
            Health += heal * _healerBenefit;
        }
    }
}
