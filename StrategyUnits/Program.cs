using StrategyUnits.Units;

internal class Program
{
    private static void Main(string[] args)
    {
        Throll throll = new Throll();
        Grunt grunt = new Grunt();

        throll.Attack(grunt);
        grunt.Attack(throll);
        Console.WriteLine(throll.Health);
        Console.WriteLine(grunt.Health);
    }
}