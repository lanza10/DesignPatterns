using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Order
    {
        public abstract IMenu CreateMenu();

        public void GetTotalPrice()
        {
            var menu = CreateMenu();

            Console.WriteLine("Do you want the extra? 1-yes 2-no");
            var key = Console.ReadKey();
            Console.WriteLine();
            var wantExtra = false;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    wantExtra = true;
                    break;
                case ConsoleKey.D2:
                    wantExtra = false;
                    break;
                default:
                    Console.WriteLine("You Entered am invalid answer, try again");
                    GetTotalPrice();
                    return;
            }
            menu.AskForExtra(wantExtra);
            Console.WriteLine($"Your menu total price is {menu.Price}$");
        }
    }
}
