using System;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Archer: Unit, IArmorController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _armor;

        public Archer(int health, string name, int armor, int mindamage, int maxdamage) 
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _armor = armor;
        }
        public int Armor { get => _armor; set => _armor = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }
        public virtual void Attack(Unit unit)
        {
            if (unit.Health == 0 && Health <= 0)
                return;
            int damage = new Random().Next(_minDamage, _maxDamage); //топ логика 
            Console.WriteLine($"Личник выстрелил из лука и нанес стрелой {damage} урона Юниту: {Name}");
            unit.TakeDamage(damage);
        }
        public override void TakeDamage(int Damage)
        {
            Damage = Damage - Armor <= 0 ? 0 : Damage - Armor;
            Health -= Damage;
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Лучник (Элайн):\r\n" +
                "В мире, где стрелы становились молниями смерти, Элайн выделялась своей меткостью и хладнокровием. \n" +
                "Ее лук, выкованный из древних деревьев, стрелял точно, как будто слушая ветры войны. \n" +
                "Элайн была глазами армии, всегда готовой раскрывать тайны вражеских планов.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
