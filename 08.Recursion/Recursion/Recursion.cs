using System;

namespace Recursion
{
    class Recursion
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static void Main(string[] args)
        {

            /* 1 Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, Factorial(n));*/



            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];

            NestedLoops(0);


        }
        /* 1 static decimal Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }*/

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
