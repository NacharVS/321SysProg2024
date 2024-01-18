using System;

namespace StrategyUnitsSemenov
{
    internal class Bishop : Unit, IMagic
    {
        private int _heal; // Сколько вылечит союзникам Health
        private int _stamina; // Выносливость Bishop
        private int _maxStamina; // Максимальная выносливость Bishop

        public Bishop() : base(20, "Doctor")
        {
            _heal = 2;
            _stamina = 100;
            _maxStamina = _stamina;
        }

        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }

        public int MaxStamina
        {
            get { return _maxStamina; }
        }

        // Свойство из интерфейса IMagic
        public int HealAmount
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth}   Stamina: {Stamina}/{MaxStamina}");
        }

        // Логика метода Heal с использованием свойства HealAmount
        public void Heal(Unit unit)
        {
            if (unit.Health > unit.MaxHealth)
            {
                Console.WriteLine("Stamina > MaxStamina, value set to MaxHealth, Bishop.cs");
                unit.Health = unit.MaxHealth;
            }
            else
            {
                if (unit.MaxHealth != unit.Health && unit.Health > 0 && _stamina > 0)
                {
                    if (unit.MaxHealth - unit.Health >= _heal)
                    {
                        _stamina = _stamina - _heal;
                        unit.Health = _heal + unit.Health;
                        Console.WriteLine($"Bishop healed {unit.Name} by {_heal} health.");
                    }
                    else
                    {
                        _stamina -= unit.MaxHealth - unit.Health;
                        unit.Health = unit.MaxHealth;
                        Console.WriteLine($"Bishop healed {unit.Name} to full health.");
                    }
                }
            }
        }

    }
}
