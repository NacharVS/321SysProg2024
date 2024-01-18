namespace StrategyUnits
{
    internal class Barracs
    {
        public Footman CreateRecruitFootman()
        {
            return new Footman("Recruit", 60, 7);
        }

        public Footman CreateAdvansedFootman()
        {
            return new Footman("Footman", 80, 9);
        }
        public Footman CreateVeteranFootman()
        {
            return new Footman("Veteran", 100, 12);
        }

    }
}
