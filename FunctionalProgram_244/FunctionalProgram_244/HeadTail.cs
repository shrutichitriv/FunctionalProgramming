using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram_244
{
    public class HeadTail
    {
        public static void CalculatePercentage()

        {
            int headcount = 0;
            int tailcount = 0;
            double headPercentage = 0;
            double tailPercentage = 0;

            Console.WriteLine("Please enter the value for number of flips");
            int numberOfFlip = Convert.ToInt32(Console.ReadLine());

            if (numberOfFlip > 0)
            {
                for (int i = 0; i < numberOfFlip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount = tailcount + 1;  //tailcount=3
                    }
                    else
                    {
                        headcount++;  // headcount=2
                    }
                }
                headPercentage = headcount * 100 / numberOfFlip;

                tailPercentage = tailcount * 100 / numberOfFlip;

                Console.WriteLine("Head Percentage " + headPercentage);
                Console.WriteLine("Tail Percentage " + tailPercentage);
            }
            else
            {
                Console.WriteLine("The number of flip is not valid");
            }
        }
    }
}
