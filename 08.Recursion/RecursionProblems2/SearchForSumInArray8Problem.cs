using System;

namespace RecursionProblems2
{
    class SearchForSumInArray8Problem
    {
        //8
        const int EMPTY_ARRAY_SPACE = -10000;

        static void SearchForSumInArray(int[] intNumArray, int targetSum, int currentSum, int currentIndex, int[] sumNumbers)
        {
            if (currentIndex > intNumArray.Length - 1)
            {
                return;
            }
            else
            {
                for (int i = currentIndex; i < intNumArray.Length; i++)
                {

                    currentSum += intNumArray[i];
                   
                    PushNumber( sumNumbers, intNumArray[i]);
                    if (currentSum == targetSum)
                    {
                        Console.Write("There is an array which equals {0}! ", currentSum);
                        PrintNumbersToSum(sumNumbers);
                        Console.WriteLine();
                    }
                    
                    SearchForSumInArray(intNumArray, targetSum, currentSum, i + 1, sumNumbers);
                    currentSum -= intNumArray[i];
                    PopNumber( sumNumbers);

                }
            }
           



        }
        static void PrintNumbersToSum(int[] sumNumbers)
        {

          
            for (int i = 0; i < sumNumbers.Length; i++)
            {
                if (sumNumbers[i] != EMPTY_ARRAY_SPACE)
                {
                    Console.Write(sumNumbers[i]);

                    if (i < sumNumbers.Length - 1 && sumNumbers[i + 1] != EMPTY_ARRAY_SPACE)
                    {
                        Console.Write(" + ");
                    }

                }

            }



        }

        static void PushNumber( int[] sumNumbers, int num)
        {
            int i = 0;
            while (sumNumbers[i] != EMPTY_ARRAY_SPACE && i < sumNumbers.Length)
            {
                i++;
            }
            sumNumbers[i] = num;

        }

        static void PopNumber( int[] sumNumbers)
        {
            int i = sumNumbers.Length - 1;
            while (sumNumbers[i] == EMPTY_ARRAY_SPACE && i > 0)
            {
                i--;
            }
            sumNumbers[i] = EMPTY_ARRAY_SPACE;
        }

        

        static int[] ConvertToIntArray(string[] numArray)
        {
            int[] intNumArray = new int[numArray.Length];

            for (int i = 0; i < numArray.Length; i++)
            {
                int.TryParse(numArray[i], out intNumArray[i]);
            }

            return intNumArray;
        }

        static void InitializeWithEmptySpace(int[] sumNumbers)
        {
            for (int i = 0; i < sumNumbers.Length; i++)
            {
                sumNumbers[i] = EMPTY_ARRAY_SPACE;
            }

        }


        


        static void Main(string[] args)
        {

            // 8
            Console.Write("Enter the numbers in your array: ");
            string numbers = Console.ReadLine();
            string[] numArray = numbers.Split(' ');
            Console.Write("Enter the sum you want to see: ");
            int n = int.Parse(Console.ReadLine());
            int[] parsedNumsArray = ConvertToIntArray(numArray);
            int[] sumNumbers = new int[parsedNumsArray.Length];
            InitializeWithEmptySpace(sumNumbers);            
            SearchForSumInArray(parsedNumsArray, n, 0, 0, sumNumbers);
        }

    }
}
