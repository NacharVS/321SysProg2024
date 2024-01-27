//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StrategyUnits.Buildings
//{
//    internal class Build 
//    {
//        private string? _name;
//        private int _currentHealth;
//        public int MaxHealth { get; private set; }

//        public Build(int health, string? name)
//        {
//            _currentHealth = health;
//            _name = name;
//            MaxHealth = health;
//        }
//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public int Health
//        {
//            get => _currentHealth;
//            set
//            {
//                if (value < 0) _currentHealth = 0;
//                else if (value > MaxHealth) _currentHealth = MaxHealth;
//                else _currentHealth = value;
//            }
//        }
//    }
//}
