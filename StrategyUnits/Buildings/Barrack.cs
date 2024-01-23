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
            => new Footman("Новичок с палкой", 60, 5, 4, 8);
        public Footman RecruitAdvancedFootman()
            => new Footman("Бывалый с мечом", 80, 25, 17, 17);
        public Footman RecruitBossFootman()
            => new Footman("Босс качалки со штангой", 100, 9, 8, 13);

        public Berserk RecruitBerserk()
            => new Berserk("Бешеный челик с рейджем", 50, 0, 20, 20);

        public Palladin RecruitPalladin()
            => new Palladin("Непробиваемый танк ИС-2", 50, 9, 20, 20, 100);

        public Archer RecruitRookieArcher()
            => new Archer("Новичок с горохострелом", 60, 5, 3, 7);
        public Archer RecruitAdvancedArcher()
            => new Archer("Бывалый с луком", 80, 7, 5, 9);
        public Archer RecruitBossArcher()
            => new Archer("Босс качалки с эмкой", 100, 15, 8, 13);

        public Healer RecruitRookieHealer()
            => new Healer("Новичок с высохшим посохом", 10, 1, 1, 5, 70);
        public Healer RecruitAdvancedHealer()
            => new Healer("Бывалый с посохом", 10, 1, 1, 5, 70);
        public Healer RecruitBossHealer()
            => new Healer("Босс качалки с магической штангой", 10, 1, 1, 5, 70);
    }
}
