using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Even_fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 1;
            int fib2 = 2;
            int fib3 = 0;
            
            int fibcount = 2;
            int evenfibsum = 0;
            int num = 0;
            List<int> fibonaccisequence = new List<int>();
            fibonaccisequence.Add(fib1);
            fibonaccisequence.Add(fib2);
            //get fibonacci sequence
            while (fib3 < 4000000)
            {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                fibonaccisequence.Add(fib2);
                Console.WriteLine(fib2);
                fibcount++;
                fib3 = fib1 + fib2;
            }
            //find even numbers and add to total
            for (int i=0; i < fibcount;i++)
            {
          
                num = fibonaccisequence[i];
                if (num % 2 == 0)
                {
                    evenfibsum = evenfibsum + num;
                    Console.WriteLine(evenfibsum);
                }
            }
            Console.WriteLine("the sum of even numbers in the fibonacci sequence is " + evenfibsum);
            Console.ReadLine();
        }
    }
}
