using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram_244
{
    public class EvenAndOdd
    {
        public static void CheckEvenOrOdd()
        {
            int n;
            Console.WriteLine(" Enter the Number to check ");
            n = int.Parse(Console.ReadLine());


            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is an Even number");
            }
            else
            {
                Console.WriteLine(n + " is an Odd number");
            }
        }
    }
}
