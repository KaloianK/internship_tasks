using System;

namespace RecursionProblems2
{
    class RecursionProblems2
    {



        static void SearchForSumInArray(int[] intNumArray, int n, int sum, int k)
        {
            if (k > intNumArray.Length - 1)
            {
                return;
            }
            else
            {
                for (int i = k; i < intNumArray.Length; i++)
                {

                    sum += intNumArray[i];
                    Console.WriteLine(sum);

                    if (sum == n)
                    {
                        Console.WriteLine("There is an array which equals {0}!", sum);

                    }
                    //if (sum > n)
                    //{
                    //    sum -= intNumArray[i];
                    //}
                    SearchForSumInArray(intNumArray, n, sum, i + 1);
                    sum -= intNumArray[i];

                }
            }
            //SearchForSumInArray(intNumArray, n, sum, k + 1);



        }

        static void SearchSumForSingleNumber(int[] singleNumArray, int i, int n)
        {
            if (i > singleNumArray.Length - 1)
            {
                return;
            }
            int firstNumber = singleNumArray[i];
            int result = 0;
            for (int m = i + 1; m < singleNumArray.Length; m++)
            {
                result = firstNumber + singleNumArray[m];
                if (result == n)
                {
                    Console.WriteLine("There is an array which equals {0}! FromSingle", n);
                }
                if (result > n)
                {
                    result -= singleNumArray[m];
                }
            }

            result = 0;
            SearchSumForSingleNumber(singleNumArray, i + 1, n);

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

        static void PrintArray(int[] intNumsArray, int n)
        {

            for (int i = 0; i < intNumsArray.Length; i++)
            {

                SearchForSumInArray(intNumsArray, n, 0, 0);
                //Console.WriteLine(intNumsArray[i]);
                //SearchSumForSingleNumber(intNumsArray, 0, n);
                //Console.WriteLine(intNumsArray[i]);
            }
           

        }
        /* static void SearchSumInArray(string[] usedNumbers, string[] givenNumbers, int searchedSum)
         {

             numbersList.Remove(1);

             for(int i = 0; i < givenNumbers.Length; i ++)
             {
                 usedNumbers[i] = givenNumbers[i];
                 givenNumbers.
             }
         }*/


        static void Main(string[] args)
        {

            // 8
            Console.Write("Enter the numbers in your array: ");
            string numbers = Console.ReadLine();
            string[] numArray = numbers.Split(' ');
            Console.Write("Enter the sum you want to see: ");
            int n = int.Parse(Console.ReadLine());
            int[] parsedNumsArray = ConvertToIntArray(numArray);
            SearchForSumInArray(parsedNumsArray, n, 0, 0);
        }

    }
}
