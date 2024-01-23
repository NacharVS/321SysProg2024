﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer: MagicUnit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Healer() : base(50, "Healer", 25,60, 0, 0)
        {
            _heal = 7;
        }

        public void AddHeal(Unit unit)
        {
            if (Energy < 2)
            {
                return;
            }

            int missingHealth = unit.MaxHealth - unit.Health;

            if (missingHealth * 2 > Energy)
            {
                missingHealth = Energy / 2;
            }

            unit.Health += missingHealth;
            Energy -= missingHealth * 2;
        }
    }
 }
