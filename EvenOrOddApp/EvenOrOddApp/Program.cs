using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddApp
{
    //Create a function (or write a script in Shell) that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 - " + EvenOrOdd(3));
            Console.WriteLine("2 - " + EvenOrOdd(2));
            Console.WriteLine("-1 - " + EvenOrOdd(-1));
        }

        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}
