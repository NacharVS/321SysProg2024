namespace StrategyUnits
{
    internal class Footman : Unit, IArmorController, IDamageController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _armor;
        public Footman(int health, string name, int armor, int mindamage, int maxdamage)
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _armor = armor;
        }

        public int Armor { get => _armor; set => _armor = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }

        public void Attack(Unit unit)
        {
            if (unit.Health <= 0)
                return;

            int damage = new Random().Next(_minDamage, _maxDamage); //топ логика 

            if (Health > 0)
            {
                Console.WriteLine($"Пехотинец нанес ударом дубины {damage} урона Юниту: {Name}");
                unit.TakeDamage(damage);
            }
            else
                return;

        }
        public override void TakeDamage(int Damage)
        {
            Damage = Damage - Armor <= 0 ? 0 : Damage - Armor;
            Health -= Damage;
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Пехотинец (Джейк): \n" +
                "Джейк, простой пехотинец, носил на себе бремя первых ударов. \n" +
                "Его щит был стеной защиты, а меч – инструментом справедливости. \n" +
                "Он был камнем фундамента армии, поддерживающим вес свободы.");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}

