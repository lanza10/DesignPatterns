using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
     class Program
    {
        public static void Main()
        {
            Order order;
            Console.WriteLine("Select your menu :\t1-Burger\t2-Pizza");
            var key = Console.ReadKey();
            Console.WriteLine();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    order = new BurgerOrder();
                    break;
                case ConsoleKey.D2:
                    order = new PizzaOrder();
                    break;
                default:
                    Console.WriteLine("You Entered am invalid value, try again");
                    Main();
                    return;
            }
            order.GetTotalPrice();
            Console.ReadLine();
            return;
        }
    }
}
