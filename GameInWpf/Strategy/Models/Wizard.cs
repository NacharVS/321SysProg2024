using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public partial class Wizard : Unit
    {
        public Wizard(int currentStrength, int maxStrength, int currentDexterity, int maxDexterity, int currentInteligence, int maxInteligence, int currentVitality, int maxVitality) : base(currentStrength, maxStrength, currentDexterity, maxDexterity, currentInteligence, maxInteligence, currentVitality, maxVitality)
        {
            Health = 1.4 * currentVitality + 0.2 * currentStrength;
            Mana = 1.5 * currentInteligence;
            Damage = 0.5 * currentStrength;
            Armor = currentDexterity;
            MediumDamage = currentInteligence;
            MediumDefense = currentInteligence;
            CriticalChanse = 0.2 * currentDexterity;
            CriticalDamage = currentDexterity;
        }
    }
}
