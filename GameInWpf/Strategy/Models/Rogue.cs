using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public partial class Rogue : Unit
    {
        public Rogue(int currentStrength, int maxStrength, int currentDexterity, int maxDexterity, int currentInteligence, int maxInteligence, int currentVitality, int maxVitality) : base(currentStrength, maxStrength, currentDexterity, maxDexterity, currentInteligence, maxInteligence, currentVitality, maxVitality)
        {
            Health = 1.5 * currentVitality + 0.5 * currentStrength;
            Mana = 1.2 * currentInteligence;
            Damage = 0.5 * currentStrength + 0.5 * CurrentDexterity;
            Armor = 1.5 * currentDexterity;
            MediumDamage = 0.2 * currentInteligence;
            MediumDefense = 0.5 * currentInteligence;
            CriticalChanse = 0.2 * currentDexterity;
            CriticalDamage = currentDexterity;
        }
    }
}
