using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : Builds
    {
        private int _regenerateStamina;
        public Altar() : base(9, "Алтарь")
        {
            _regenerateStamina = 5;
        }

        public int RegenerateStamina
        {
            get { return _regenerateStamina; }
            set { _regenerateStamina = value;}
        }

        public void RecoveryStamina(Bishop bishop)
        {
            if(bishop.MaxStamina > bishop.Stamina )
            {
                if(bishop.MaxStamina - bishop.Stamina < _regenerateStamina)
                    bishop.Stamina = bishop.MaxStamina;
                else
                {
                    bishop.Stamina += _regenerateStamina;
                }
            }
        }
    }
}
