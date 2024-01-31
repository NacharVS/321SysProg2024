namespace StrategyUnits
{
    internal class Peasant : Unit
    {

        public Peasant() : base(50, "Peasent")
        {
            
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Житель (Альфред): \b \n" +
                "Альфред, простой житель, служил своему дому с преданностью. \n" +
                "Его работы на полях и в лесах обеспечивали армию ресурсами. \n" +
                "Он был тихим героем, на чьих плечах лежал фундамент благополучия.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
