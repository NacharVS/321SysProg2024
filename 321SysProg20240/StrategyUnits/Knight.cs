using System;

namespace StrategyUnits
{
    internal class Knight : Unit, IManaController, IArmorController, IDamageController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _mana;
        private int _maxMana;
        private int _armor;
        private int _healStrange;
        public Knight(int health, string? name, int armor, int mindamage, int maxdamage, int healStrange, int mana)
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _armor = armor;
            _healStrange = healStrange;
            _maxMana = mana;
            _mana = mana;
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

        public void Attack(Unit unit)
        {
            if (unit.Health == 0 && Health <= 0)
                return;
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Рыцарь нанесн ударом меча {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
        public override void TakeDamage(int Damage)
        {
            Damage = Damage - Armor <= 0? 0 : Damage - Armor;
            Health -= Damage;
        }
        public void SelfHeal()
        {
            if (Health == 0)
                return;

            if (MaxHealth - Health > HealStrange && MaxHealth >= Health)
            {
                if (Mana < HealStrange && Mana != 0)
                {
                    Health += Mana;
                    Mana = 0;
                }
                else if (Mana > HealStrange)
                {
                    Health += HealStrange;
                    Mana -= HealStrange;
                }
            }
            else
            {
                if (Mana < MaxHealth - Health && Mana != 0)
                {
                    Health += Mana;
                    Mana = 0;
                }
                else if (Mana > MaxHealth - Health && MaxHealth > Health)
                {
                    Mana -= MaxHealth - Health;
                    Health = MaxHealth;
                }
            }
        }
        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Рыцарь (Сирил):\r\n" +
                "Сирил, рыцарь со вкусом аристократии, возвышал свою армию своим благородством и мастерством на поле боя.\n" +
                "Его меч был точен, как его ум, и его доспехи сияли светом справедливости.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"    current mana: {Mana} / {_maxMana}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
