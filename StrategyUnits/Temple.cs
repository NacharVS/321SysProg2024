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
        private int _EnTemple;
        public int Mana
        {
            get { return _Mana; }
            set { _Mana = value; }
        }
        public int EnergyTem
        {
            get => _EnTemple;
            set => _EnTemple = value;
        }

        public Temple() : base(30, "Temple")
        {
            _Mana = 1;
            _EnTemple = 100;

        }
        public void InflictMAna(Wizard wizard)
        {
            while (wizard.Energy < wizard.MAxEnergy && _EnTemple  > 0)
            {

                wizard.Energy += _Mana;
                _EnTemple -= 1;


            }
          
        }
        public override void ShowInfo() => Console.WriteLine($"Unit: {this.Name} Health: {this.Health}/{this.MaxHealth} Energy: {EnergyTem}");
    }
}
