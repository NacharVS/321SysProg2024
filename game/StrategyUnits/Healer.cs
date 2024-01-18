using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
       
        public Healer() : base (100, "Healer", 1, 2, 1,25,1)
        {
            
        }
        
    }
}
