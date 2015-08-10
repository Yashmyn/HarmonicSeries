using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSeries
{
    class Harmonic
    {
        //METHOD to do the left-to-right addition
        public static void leftToRight()
        {
            //first number in the harmonic series will be represented by n-1; y is the running sum; for numbers to be properly reported, they must be of type decimal.
            decimal n;
            decimal y = 0;

            for (n = 0; n < 50000; n++)
            {
                //The ...else in this first if...else keeps "1" from printing as a fraction.
                if (n != 0)
                {
                    Console.Write(1 + "/" + (n + 1));
                }
                else Console.Write(1);

                y += (1 / (n + 1));
                //write addition sign only when n<49,999 because, again, n is one less than the number in the harmonic series.
                if (n < 49999)
                {
                    Console.Write("   +   ");
                }
            }
            Console.WriteLine(" = {0:F3}", y);
        }

        //METHOD to do the right-to-left addition
        public static void rightToLeft()
        {
            //variable for, again, the running sum.
            decimal n;
            decimal y = 0;

            //set n to 49,999 instead of 50,000 to avoid having to create an additional step to avoid dividing by 0 in denominator.
            for (n = 49999; n >= 0; n--)
            {
                if (n > 0)
                {
                    Console.Write(1 + "/" + (n + 1));
                }
                else Console.Write(1);

                y += (1 / (n + 1));
                if (n > 0)
                {
                    Console.Write("   +   ");
                }
            }
            Console.WriteLine(" = {0:F3}", y);
        }
    }
}

