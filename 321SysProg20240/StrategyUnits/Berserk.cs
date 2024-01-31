using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Unit, IArmorController, IDamageController
    {
        private int _minDamage;
        private int _maxDamage;
        private int _armor;
        public Berserk(int health, string name, int armor, int mindamage, int maxdamage)
            : base(health, name)
        {
            _minDamage = mindamage;
            _maxDamage = maxdamage;
            _armor = armor;
            Rage = false;
        }
        public int Armor { get => _armor; set => _armor = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }

        public bool Rage { get; set; }

        public override int Health
        {
            get { return base.Health; }
            set
            {
                base.Health = value;
                if (value <= MaxHealth / 2 && !Rage)
                {
                    Rage = true;
                    MinDamage += MaxDamage;
                    MinDamage *= 2;
                    Console.WriteLine("Берсерк впал в ярость!");
                }
                else if (value > MaxHealth / 2 && Rage)
                {
                    MinDamage /= 2;
                    MaxDamage -= MinDamage;
                    Rage = false;
                    Console.WriteLine("Берсерк успокоился");
                }

            }

        }

        public void Attack(Unit unit)
        {
            if (unit.Health == 0 && Health <= 0)
                return;
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Берсерк нанесн ударом топора {damage} урона Юниту: {Name}");
            TakeDamage(damage);
        }

        public override void TakeDamage(int Damage)
        {
            Damage = Damage - Armor <= 0 ? 0 : Damage - Armor;
            Health -= Damage;
        }

        public override void TakeStory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Берсерк (Гримм):\r\n" +
                "Гримм, сражаясь с безудержным неистовством, был олицетворением силы в бурю битвы. \n" +
                "Его топор, метавшийся как молния, становился судьбой врагов. \n" +
                "Он был огненным вихрем, разрывающим линии противника и вдохновляющим своих собратьев на подвиги.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
