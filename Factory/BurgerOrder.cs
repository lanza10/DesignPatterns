﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BurgerOrder : Order
    {
        public override IMenu CreateMenu()
        {
            return new BurgerMenu();
        }
    }
}
