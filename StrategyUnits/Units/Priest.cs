using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Priest : Unit, IManaRestore, IHealerUnit
    {
        private const int _healerBenefit = 2;
        private const int _healCost = 10;
        public Priest(string name, int health, int heal, int manaReserve) : base(health, name)
        {
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

        public void ManaRestoring(IHealerUnit unit)
        {
            if (ManaReserve < 0)
                ManaReserve = 0;
            while (ManaReserve >= _healCost)
            {
                unit.TakeMana(Heal);
                ManaReserve -= _healCost;
            }
        }

        public void ManaRestoring()
        {
            throw new NotImplementedException();
        }

        public override void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }

        public override void TakeHealth(int heal)
        {
            Health += heal * _healerBenefit;
        }

        public void TakeMana(int mana)
        {
            throw new NotImplementedException();
        }
    }
}
