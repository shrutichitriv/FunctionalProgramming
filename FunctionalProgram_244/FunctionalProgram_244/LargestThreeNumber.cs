using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram_244
{
    public class LargestThreeNumber
    {
        public static void Show()
        {
            //Accept Three Values From User
            Console.WriteLine("Input the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)//Check Num1 greater Than Num 
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three");
                }
            }
            else if (num2 > num3)//Check Num2 Greater Than Num3
            {
                Console.Write("The 2nd Number is the greatest among three ");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three ");
            }
        }
    }
}
