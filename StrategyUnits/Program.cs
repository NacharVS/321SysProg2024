using StrategyUnits.Buildings;
using StrategyUnits.Units;
using System;
namespace StrategyUnits 
{ 
    class Program
    {
        static void Main(string[] args) 
        { 
            Barak barak = new Barak();
            Knight palladin = barak.GetPalladin();
            Footman footman = barak.GetFootman();
            Peasant peasant = new Peasant();
            Doctor doctor = new Doctor();
            Footman berserk = barak.GetBerserk();

            peasant.ShowInfo();
            footman.DealDamage(peasant);
            footman.DealDamage(peasant);
            footman.DealDamage(peasant);
            footman.DealDamage(peasant);
            peasant.ShowInfo();
            doctor.IncreaseHeal(peasant);
            peasant.ShowInfo();

            footman.DealDamage(berserk);
            footman.DealDamage(berserk);
            footman.DealDamage(berserk);
            footman.DealDamage(berserk);
            footman.DealDamage(berserk);
            berserk.ShowInfo();
            doctor.IncreaseHeal(berserk);
            berserk.ShowInfo();

            berserk.DealDamage(palladin); 
            berserk.DealDamage(palladin);
            berserk.DealDamage(palladin);
            berserk.DealDamage(palladin);
            palladin.ShowInfo();
            palladin.SelfHeal();
            palladin.ShowInfo();

        }



    }
}


