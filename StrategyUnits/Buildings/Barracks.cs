using StrategyUnits.Unit;
using StrategyUnits.Interface;

namespace StrategyUnits
{
    internal class Barracks : IHealthControl
    {
        public Barracks() 
        {
            Name = "Barrack";
            MaxHealth = 300;
            Health = 300;
            IsDead = false;
        }

        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} разрушен.");
                IsDead = true;
            }
            else Console.WriteLine($"{Name} получил {damage} урона. Тек. здоровье: {Health}/{MaxHealth}");
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health > MaxHealth)
                Health = MaxHealth;
            else Console.WriteLine($"{Name} уже не спасти...");
        }

        public Footman CreateFootman()
        {
            return new Footman();
        }

        public Berserk CreateBerserk()
        {
            return new Berserk();
        }

        public Knight CreateKnight()
        {
            return new Knight();
        }

        public Palladin CreatePalladin()
        {
            return new Palladin();
        }

        public Healer CreateHealer()
        {
            return new Healer();
        }
    }
}
