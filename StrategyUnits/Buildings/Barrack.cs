using StrategyUnits.MilitaryUnits;
using StrategyUnits.MilitaryUnits.MagicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Barrack : Building
    {
        public Barrack(string name) : base(name, 1000)
        {

        }

        public Footman RecruitRookieFootman()
        {
            return new Footman("Новичок с палкой", 60, 5, 4, 8);
        }
        public Footman RecruitAdvancedFootman()
        {
            return new Footman("Бывалый с мечом", 80, 6, 11, 11);
        }
        public Footman RecruitBossFootman()
        {
            return new Footman("Босс качалки со штангой", 100, 9, 8, 13);
        }
        public Berserk RecruitBerserk()
        {
            return new Berserk("Бешеный челик с рейджем", 50, 15, 20, 20);
        }

        public Archer RecruitRookieArcher()
        {
            return new Archer("Новичок с горохострелом", 60, 5, 3, 7);
        }
        public Archer RecruitAdvancedArcher()
        {
            return new Archer("Бывалый с луком", 80, 7, 5, 9);
        }
        public Archer RecruitBossArcher()
        {
            return new Archer("Босс качалки с эмкой", 100, 15, 8, 13);
        }

        public Healer RecruitRookieHealer()
        {
            return new Healer("Новичок с высохшим посохом", 10, 1, 1, 5, 70);
        }
        public Healer RecruitAdvancedHealer()
        {
            return new Healer("Бывалый с посохом", 10, 1, 1, 5, 70);
        }
        public Healer RecruitBossHealer()
        {
            return new Healer("Босс качалки с магической штангой", 10, 1, 1, 5, 70);
        }
    }
}
