using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Barrack : Building// obama
    {
        public Barrack(string name, int health) : base(name, health) { }

        public Barbarian TrainNewbieBarbarian() =>
           new Barbarian("Дохлячок", 75, 20, 5);
        public Barbarian TrainRegularBarbarian() =>
           new Barbarian("Норм челик", 85, 25, 7);
        public Barbarian TrainDangeonBarbarian() =>
           new Barbarian("Бос", 100, 30, 10);

        public Healer TrainHealer() =>
            new Healer("Феечка", 15, 5, 100);
    }
}
