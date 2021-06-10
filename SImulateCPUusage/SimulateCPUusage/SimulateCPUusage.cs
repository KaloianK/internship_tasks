using System;
using System.Numerics;

namespace SimulateCPUusage
{
    class SimulateCPUusage
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = 1;
            BigInteger secondNumber = 1;

            while(true)
            {
                BigInteger sumOfFirstAndSecondNumber = firstNumber + secondNumber;
                Console.WriteLine("Fibonacci:" + sumOfFirstAndSecondNumber);
                Console.WriteLine("Power of: " + sumOfFirstAndSecondNumber * sumOfFirstAndSecondNumber);
                firstNumber = secondNumber;
                secondNumber = sumOfFirstAndSecondNumber;
            }
        }
    }
}
