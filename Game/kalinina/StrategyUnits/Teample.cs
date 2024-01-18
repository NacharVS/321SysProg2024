using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Teample
    {

      
        public int energy { get; set; }
        public Teample( int ElementaryEnargy)
        {
            energy = ElementaryEnargy;
        }

        

        public void Addenergy(MagicUnit magicUnit)
        {
            if (MagicUnit.energy > 0)
            {
                int energyCount=Math.Min(magicUnit.MaxEnergy - magicUnit.Energy, energy);
                magicUnit.Energy += energyCount * 10;
                energy -= energyCount;
            }
        }



    }
}
