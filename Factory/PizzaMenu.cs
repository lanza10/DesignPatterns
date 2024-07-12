using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaMenu : IMenu
    {
        public string Extra { get; set; } = "";
        public double Price { get; set; } = 10.50;
        public void AskForExtra(bool wantExtra)
        {
            if (!wantExtra) return;
            Extra = "Garlic sauce + Soda";
            Price += 4;
        }
    }
}
