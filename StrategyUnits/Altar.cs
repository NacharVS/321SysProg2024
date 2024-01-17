using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        private string? _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _unbreaking;
        public int Unbreaking
        {
            get { return _unbreaking; }
            set
            {
                if (value < 0)
                {
                    _unbreaking = 0;
                }
                else
                {
                    _unbreaking = value;
                }
            }
        }
        public Altar(string name, int unbreaking)
        {
            _name = name;
            _unbreaking = unbreaking;
        }

        //public void RegenerateStamina(Healer healer)
        //{
        //    while (healer.Stamina < healer.MaxStamina)
        //    {
        //        healer.Stamina += 2;
        //        Thread.Sleep(millisecondsTimeout: 100);
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine($"+2 stamina || {healer.Stamina}/{healer.MaxStamina}");
        //        Console.ResetColor();
        //    }
        //}
    }
}
