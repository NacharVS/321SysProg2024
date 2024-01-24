using System.Net.Http.Headers;

namespace StrategyUnits
{
    internal class Barracks
    {
        public Footman CreateFootman()
        {
            return new Footman("Footman", 60, 5, 10, 15);
        }
        public Bersercer CreateBersercer()
        {
            return new Bersercer("Bersercer", 70, 7, 15, 25);
        }
        public Healer CreateHealer()
        {
            return new Healer("Healer", 45, 4, 5,10, 60, 1);
        }
        public Knight CreateKnight()
        {
            return new Knight("Knight", 55, 6, 10, 20, 30);
        }
        public Paladin CreatePalladin()
        {
            return new Paladin("Paladin", 69, 7, 12, 25, 35);
        }
    }
}
