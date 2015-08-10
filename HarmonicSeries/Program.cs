using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSeries
{
    class Program
    {
        static void Main(string[] args)
        {

            //setting size of console window to better accommodate quantity of numbers that will fly up the screen
            Console.SetWindowSize(130, 45);

            //user invited to press a key to enter the rabbit hole...
            Console.Write("To see the harmonic series summed, where n = 50,000, press any key: ");
            Console.ReadLine();
            Console.WriteLine();

            //this function will add the series of 50,000 numbers from left to right
            Harmonic.leftToRight();

            //inviting users to go back out the rabbit hole, so to speak...
            Console.Write("\nTo see the harmonic series summed from right to left this time, press any key: ");
            Console.ReadLine();
            Console.WriteLine();

            //this function will add the series from right to left
            Harmonic.rightToLeft();

            Console.ReadLine();
        }
    }
}

