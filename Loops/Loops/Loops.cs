using System;

namespace Loops
{
    class Loops
    {
        static void Main(string[] args)
        {
            /*int counter = 0;
            while (counter <= 9)
            {
                Console.WriteLine("Number : " + counter);
                counter++;
            }*/


            /* Console.Write("n = ");
             int n = int.Parse(Console.ReadLine());
             int num = 1;
             int sum = 1;
             Console.Write("The sum ");
             Console.Write(num);
             while (num < n)
             {

                 num++;
                 sum += num;
                 Console.Write(" + " + num);
             }
             Console.Write(" = " + sum);
            */

            /*Console.Write("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool isPrime = true;
            if (num < 0)
            {
                Console.WriteLine("Enter a valid number!");
            }
            else
            {
                while (isPrime && (divider <= maxDivider))
                {
                    if (num % divider == 0)
                    {
                        isPrime = false;
                    }
                    divider++;
                }
                Console.WriteLine("Prime? " + isPrime);
            }
            */
            /*Console.Write("Enter a number you want factorial of: ");
            int factNumber = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            while (true)
            {
                 if (factNumber <= 1)
                 {
                     break;
                 }
                 else
                 {
                     factorial *= factNumber;
                     factNumber--;
                 }
            }
             Console.WriteLine("The factorial of your number = {0}", factorial);
            */
            /* Console.Write("n = ");
             int n = int.Parse(Console.ReadLine());
             decimal factorial = 1;
             do
             {
                 factorial *= n;
                 n--;
             }
             while (n > 0);
             Console.WriteLine("n! = {0}", factorial);
            */
            /*Console.Write("Enter a number for 'N': ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a number for 'M': ");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;
            do
            {
                product *= num;
                num++;

            }
            while (num <= m);
            Console.WriteLine("The product of [N...M] = " + product);
            */
            /*Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            decimal result = 1;
            for(int i = 0; i < m; i++)
            {
                result *= n;
            }
            Console.WriteLine("n^m = " + result);*/
            /*int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i += 2)
            {
                if(i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("Sum = " + sum);
            */
            /*int[] numbers = { 2, 3, 5, 7, 11, 13, 15 };
            foreach (int i in numbers)
            {
                Console.Write("-" + i);
            }
            Console.WriteLine();
            string[] towns = { "Sofia", "Veliko Tarnovo", "London", "New York" };
            foreach(string town in towns)
            {
                Console.Write("-" + town);
            }
            */
            /*int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <=n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            */
            //1
            /*Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <=num; i++)
            {
                Console.WriteLine(i + " ");
            }
            */
            //2
            /*Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i + " ");
            }
            */
            //3 ??????????????????????????????????????????????????????????????????????????/
            /* Console.Write("Enter random numbers: ");
             string numbers = Console.ReadLine();
             string[] intNumbers = numbers.Split(' ');
             int[] parsed = new int[intNumbers.Length];
             int maxNumber;
             int.TryParse(intNumbers[0], out maxNumber);
             int minNumber;
             int.TryParse(intNumbers[0], out minNumber);

             for (int i = 1; i < intNumbers.Length; i++)
             {
                 int currentNumber;

                 if (!int.TryParse(intNumbers[i], out currentNumber))
                 {
                     continue;
                 }

                 if (currentNumber < minNumber)
                 {
                     minNumber = currentNumber;
                 }
                 else if (currentNumber > maxNumber)
                 {
                     maxNumber = currentNumber;
                 }
             }
             Console.WriteLine(minNumber + " " + maxNumber);
             Console.WriteLine("MinNumber: {0} \nMaxNumber: {1}", minNumber, maxNumber);*/
            /*{
                int n = 0;
                for (int i = 1; i <= intNumbers; i++)
                {
                    n += 1; ;
                    Console.WriteLine(n);
                }
            }*/
            //4
            /* int cards = 14;
             int color = 4;
             for (int i = 2; i <=cards; i++)
             {
                 for(int k = 1; k <=color; k ++)
                 {
                     Console.WriteLine(i + "-" + k + " ");
                 }
             }
             Console.WriteLine("On the left is the card number where '11', '12', '13', '14' stands respectively for J(Jack), Q(Queen), K(King), A(Ace)");
             Console.WriteLine("On the right is the color number where '1' is for 'Clubs', 2 - 'Diamonds', 3 - 'Hearts', 4 - 'Spades'");
            */
            //5
            /*Console.Write("Enter a number 'N': ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 1;
            int nDigit = 0;
            for(int i = 1; i <= number; i ++)
            {
                nDigit = firstDigit + secondDigit;
                firstDigit = secondDigit;
                secondDigit = nDigit;
            }
            Console.WriteLine(nDigit);*/
            //6
            /* Console.Write("Enter a number for 'N': ");
             int nNumber = int.Parse(Console.ReadLine());
             Console.Write("Enter a number for 'K': ");
             int kNumber = int.Parse(Console.ReadLine());
             decimal factorialN = 1;
             decimal factorialK = 1;
             do
             {
                 factorialN *= nNumber;
                 nNumber--;
             }
             while (nNumber > 0);
             do
             {
                 factorialK *= kNumber;
                 kNumber--;
             }
             while (kNumber > 0);
             Console.WriteLine(factorialN);
             Console.WriteLine(factorialK);
             Console.WriteLine(factorialN / factorialK);
            */
           /* int sum = 0;
            int finalSUm;
            for (int i = 1; i <= 44; i++)
            {
                for (int k = i + 1; k <= 45; k++)
                {
                    for (int j = k + 1; j <= 46; j++)
                    {
                        for (int l = j + 1; l <= 47; l++)
                        {
                            for (int m = l + 1; m <= 48; m++)
                            {
                                for (int n = m + 1; n <= 49; n++)
                                {
                                    sum++;
                                    
                                }
                            }
                        }
                    }
                }
            }
            finalSUm = sum;
            Console.WriteLine(finalSUm);
            */

        }
    }
}
