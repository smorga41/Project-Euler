using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {// sum of squares
            long sumsquare = 0;
            
            for (int i = 1; i <= 100; i++)
            {
                int squarei = i * i;
                sumsquare = sumsquare + squarei;
            }
            Console.WriteLine(sumsquare);
            // square of sum
            int sumofnum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumofnum = sumofnum + i;
            }
            Console.WriteLine(sumofnum);
            long sqsumofnum = sumofnum * sumofnum;
            Console.WriteLine(sqsumofnum);
            long difference = sqsumofnum - sumsquare;
            Console.WriteLine(difference);
            Console.ReadLine();
        }
    }
}
