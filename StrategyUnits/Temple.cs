using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Temple: Unit
    {
        private int _Mana;
        public int Mana
        {
            get { return _Mana; }
            set { _Mana = value; }
        }

        public Temple() : base(30, "Temple", 0)
        {
            _Mana = 1;
        }
        public void InflictMAna(MagicUnit magicUnit)
        {
            while (magicUnit.Energy < magicUnit.MAxEnergy)
            {
                magicUnit.Energy += _Mana;
            }
          
        }
        public override void ShowInfo() => Console.WriteLine($"Unit: {this.Name} Health: {this.Health}/{this.MaxHealth}");
    }
}
