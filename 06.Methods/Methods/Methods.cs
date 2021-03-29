using System;

namespace Methods
{
    class Methods
    {
        /* static void PringLogo(string logo)
         {
             Console.WriteLine(logo);
         }*/
        /* static void PrintTotalAmountForTheBooks(decimal[] prices)
         {
             decimal totalAmount = 0;
             foreach (decimal currentBookPrice in prices)
             {
                 totalAmount += currentBookPrice;
             }
             Console.WriteLine("The total amount of your books is: " + totalAmount);
         }*/
        /*static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the parameter is: ");
            PrintArray(arrParam);
        }

        static void PrintArray(int[] arrParam)
        {
            Console.Write("[");
            int length = arrParam.Length;
            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }
        */
        /*static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }
        */
        /*static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }*/

        static void Main(string[] args)
        {
            // PringLogo("Microsoft");
            /*decimal[] prices = { 3.56m, 123.23m, 54.43m };
            PrintTotalAmountForTheBooks(prices);*/
            /*int[] arrArg = new int[] { 1, 2, 3 };
            Console.Write("Before ModifyArray() the argument is: ");
            PrintArray(arrArg);
            ModifyArray(arrArg);

            Console.Write("After ModifyArray() the argument is: ");
            PrintArray(arrArg);*/
            /* long sum = CalcSum(2, 5);
             Console.WriteLine(sum);

             long sum2 = CalcSum(2, 0, -4, 13);
             Console.WriteLine(sum2);

             long sum3 = CalcSum();
             Console.WriteLine(sum3);*/
            // Entering the value of the variable n

          /*  Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);

            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }*/

        }      
    }
}
