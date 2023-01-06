using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram_244
{
    public class Swapping
    {
        public static void SwapTwoNos()
        {
            int num1, num2, temp;

            Console.WriteLine("Input the First Number :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number :");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(" After Swapping : ");
            Console.WriteLine(" First Number : " + num1);
            Console.WriteLine(" Second Number : " + num2);
            Console.Read();
        }
    }
}
