using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Healer() : base("Хилер",0,100)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense} | Мана: {Mana}/{MaxMana}");
        }
        
        public void InflictHeal(Unit unit) 
        {
            if (unit.Health <= 0)
                return;

            while(unit.Health < unit.MaxHealth) 
            {
                if (Mana == 0)
                    return;
                Mana -= 2;
                unit.Health++;
            }

        }
    }
}
