using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Builds
    {
        private int _square;
        private string _name;

        public Builds(int square, string name)
        {
            _square = square;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Square
        {
            get { return _square; }
            set { _square = value; }
        }

    }
}
