using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram_244
{
    public class PowerOfTwo
    {
        public static void CheckPowerOf2()
        {
            //Accept value From User
            Console.Write("Enter The Number Till Power Is Required:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num <= 31) //Checking If Condition
            {
                for (int i = 1; i <= num; i++)
                {
                    double result = Math.Pow(i, 2);
                    Console.WriteLine("Power Of Number:" + i + " Is:" + result);

                }
            }
        }
    }
}
