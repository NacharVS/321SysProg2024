using System;

namespace StrategyUnits
{
    internal class Paladin: Unit, IManaController, IArmorController, IDamageController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _mana;
        private int _maxMana;
        private int _armor;
        private int _healStrange;
        public Paladin(int health, string? name, int armor, int mindamage, int maxdamage, int healStrange, int mana)
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _armor = armor;
            _healStrange = healStrange;
            _maxMana = mana;
            _mana = mana;
            Shield = false;
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value >= _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
                ShowInfo();
            }
        }
        public int Armor { get => _armor; set => _armor = value; }
        public int HealStrange { get => _healStrange; set => _healStrange = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }

        public bool Shield { get; set; }

        public override int Health {
            get { return base.Health; }
            set
            {
                base.Health = value;
                if(value <= MaxHealth / 2 && !Shield)
                {
                    Shield = true;
                    Armor *= 2;
                    Console.WriteLine("Паладин активировал святой щит");
                }
                else if(value > MaxHealth / 2 && Shield)
                {
                    Armor /= 2;
                    Shield = false;
                    Console.WriteLine("Щит паладина пропал");
                }
            }
        }

        public void Attack(Unit unit)
        {
            if (unit.Health == 0 && Health <= 0)
                return;
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Палладин нанесн ударом святого меча {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Паладин (Изабель):\r\n" +
                "Изабель, паладин с сердцем чистым как свет, была защитой мира. \n" +
                "Ее меч олицетворял святость, и ее непоколебимая вера была оплотом, отражающим тьму врагов.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
