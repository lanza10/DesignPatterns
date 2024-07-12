using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BurgerMenu : IMenu
    {
        public string Extra { get; set; } = "";
        public double Price { get; set; } = 8;
        public void AskForExtra(bool wantExtra)
        {
            if (!wantExtra) return;
            Extra = "fries";
            Price += 2.50;
        }
    }
}
