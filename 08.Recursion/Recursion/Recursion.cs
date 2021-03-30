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

             Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, Factorial(n));



             Console.Write("N = ");
             numberOfLoops = int.Parse(Console.ReadLine());
             Console.Write("K = ");
             numberOfIterations = int.Parse(Console.ReadLine());
             loops = new int[numberOfLoops];

             NestedLoops(0);

          Console.Write("n = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib({0}) = {1}", num, Fib(num));
        





        }
         static decimal Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

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


        static long Fib(int n)
        {
            long fibNumber = 1;
            long fibNumberMinus1 = 1;
            long fibNumberMinus2 = 1;
            for (int i = 2; i < n; i++)
            {
                fibNumber = fibNumberMinus1 + fibNumberMinus2;
                fibNumberMinus2 = fibNumberMinus1;
                fibNumberMinus1 = fibNumber;
            }
            return fibNumber;

        }




    }
}
