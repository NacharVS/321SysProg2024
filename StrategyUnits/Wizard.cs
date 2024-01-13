using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Wizard : Unit
    {
        private int _treat;
        private int _energy;
        public int MAxEnergy { get; private set; }

        public int Treat 
        { 
            get { return _treat; }
            set { _treat = value; }
        }
      

        public int Energy
        {
            get => _energy;
            set
            {   if (value < 0)
                {
                    _energy = 0;
                }
            else if (value >= MAxEnergy)
                { 
                    _energy = MAxEnergy;
                }
            else
                {
                    _energy = value;
                }
            }
        }
        


        public Wizard() : base (30, "Wizard")
        {
            _treat = 1;
            _energy = 60;
            MAxEnergy = _energy;

        }
        public void InflictTreat(Unit unit)
        {
            while(unit.Health < unit.MaxHealth && (_energy/2)>0)
            { 
               
                    unit.Health += _treat;
                    _energy -= 2;
                
               
            }
            
        }
        public override void ShowInfo() => Console.WriteLine($"Unit: {this.Name} Health: {this.Health}/{this.MaxHealth} Energy: {Energy}");
    }
}
