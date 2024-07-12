using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IMenu
    {
        string Extra { get; set; }
        double Price { get; set; }
         public void AskForExtra(bool wantExtra);
    }
}
