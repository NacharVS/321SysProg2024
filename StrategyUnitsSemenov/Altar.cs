using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsSemenov
{
    internal class Altar : Builds
    {
        private int _regeneratedStamina; //сколько восстановило Health
        public Altar() : base(9, "Алтарь")
        {
            _regeneratedStamina = 5;
        }

        public int RegeneratedStamina
        {
            get { return _regeneratedStamina; }
            set { _regeneratedStamina = value;}
        }

        public void RecoveryStamina(Bishop[] bishops)
        {
            foreach(Bishop bishop1 in bishops)
            {
                if (bishop1.Stamina > bishop1.MaxStamina)
                {
                    Console.WriteLine("Stamina > MaxStamina, value returned, Altar.cs");
                    return;
                }

                if (bishop1.MaxStamina - bishop1.Stamina < _regeneratedStamina)
                {
                    Console.WriteLine($"Алтарь восстановил - {bishop1.MaxStamina - bishop1.Stamina}");
                    bishop1.Stamina = bishop1.MaxStamina;
                }

                else
                {
                    bishop1.Stamina += _regeneratedStamina;
                    Console.WriteLine($"Алтарь восстановил - {_regeneratedStamina}");
                }
            }
        }
    }
}
