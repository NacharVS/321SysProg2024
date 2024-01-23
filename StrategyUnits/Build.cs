namespace StrategyUnits
{
    internal class Build
    {
        private int _Health;
        private string? _name;

        public Build(int health, string? name)
        {
            _Health = health;
            _name = name;
        }
        public int Health
        {
            get { return _Health; }
            set { _Health = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_Health}");
        }
    }
}