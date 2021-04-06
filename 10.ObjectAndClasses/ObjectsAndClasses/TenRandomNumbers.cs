using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    public class TenRandomNumbers
    {

        private static Random randomNumbers = new Random();
       public static void TenRandomNumbersFunc()
        {
            for (int i = 0; i <= 10; i++)
            {
                int number = randomNumbers.Next(100) + 100;
                Console.Write("{0} ", number);
            }
        }
    }
}
