using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public partial class Warrior : Unit
    {
        public Warrior(int currentStrength, int maxStrength, int currentDexterity, int maxDexterity, int currentInteligence, int maxInteligence, int currentVitality, int maxVitality) : base(currentStrength, maxStrength, currentDexterity, maxDexterity, currentInteligence, maxInteligence, currentVitality, maxVitality)
        {
            Health = 2 * currentVitality + currentStrength;
            Mana = currentInteligence;
            Damage = currentStrength;
            Armor = currentDexterity;
            MediumDamage = 0.2 * currentInteligence;
            MediumDefense = 0.5 * currentInteligence;
            CriticalChanse = 0.2 * currentDexterity;
            CriticalDamage = currentDexterity;
        }
    }
}
