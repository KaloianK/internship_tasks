using System;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[5];
             arr[0] = 1;
             arr[1] = 2;
             arr[2] = 3;
             arr[3] = 4;
             arr[4] = 5;      
             int length = arr.Length;
             int[] reversed = new int[length];
             for (int i = 0; i < length; i++)
             {
                 reversed[length - i - 1] = arr[i];
             }
             for (int k = 0; k < length; k++)
             {
                 Console.Write(reversed[k] + " ");
             }*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /* Console.Write("Enter a positive integer: ");
             int n = int.Parse(Console.ReadLine());
             int[] array = new int[n];

             Console.WriteLine("Enter the values of the array: ");

             for (int i = 0; i < n; i++)
             {
                 array[i] = int.Parse(Console.ReadLine());
             }
             bool symetric = true;
             for (int i = 0; i < array.Length / 2; i++)
             {
                 if (array[i] != array[n - i - 1])
                 {
                     symetric = false;
                 }
             }
             Console.WriteLine("Is symetric? {0}", symetric);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////
            /*int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Reversed: ");
            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }*/
            /*int[,] matrix =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8}
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }*/
            /* Console.Write("Enter the number of rows: ");
             int rows = int.Parse(Console.ReadLine());

             Console.Write("Enter the number of columns: ");
             int cols = int.Parse(Console.ReadLine());

             int[,] matrix = new int[rows, cols];

             Console.WriteLine("Enter the cells of the matrix: ");

             for (int row = 0; row < rows; row++)
             {
                 for (int col = 0; col < cols; col++)
                 {
                     Console.Write("Matrix[{0}, {1}] = ", row, col);
                     matrix[row, col] = int.Parse(Console.ReadLine());
                 }
             }

             for (int row = 0; row < matrix.GetLength(0); row ++)
             {
                 for (int col = 0; col < matrix.GetLength(1); col++ )
                 {
                     Console.Write(matrix[row, col] + " ");
                 }
                 Console.WriteLine();
             }*/
            /*int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(0) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The maximum sum is: {0}", bestSum);
            Console.WriteLine("The Best Matrix 2x2 is: ");
            Console.WriteLine("  {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine("  {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            //Exception!?!vvvv
            //Console.WriteLine("{0} {1} \n{3} {4}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);*/
            /* int[] array = new int[20];
             for (int i = 0; i < array.Length; i++)
             {
                 array[i] = i * 5;
                 Console.Write(array[i] + " ");
             }*/
            /*Console.Write("Enter the size of your first array: ");
            int sizeOfFirstArray = int.Parse(Console.ReadLine());
            int[] firstArray = new int[sizeOfFirstArray];
            int currentElementFA = 0;
            bool areMatching = true;
            Console.WriteLine("Enter the numbers for the first array: ");

            for (int i = 0; i < sizeOfFirstArray; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the size of your second array: ");
            int sizeOfSecondArray = int.Parse(Console.ReadLine());
            int[] secondArray = new int[sizeOfSecondArray];
            int currentElementSA = 0;
            if (sizeOfSecondArray < sizeOfFirstArray || sizeOfSecondArray > sizeOfFirstArray)
            {
                Console.WriteLine("Your arrays are not matching cause they are different sizes! :)");
            }
            else
            {
                
                Console.WriteLine("Enter the numbers for the second array: ");

                for (int k = 0; k < sizeOfSecondArray; k++)
                {
                    secondArray[k] = int.Parse(Console.ReadLine());                
                }
            }
            for (int i = 0; i < firstArray.Length; i ++)
            {
                currentElementFA = firstArray[i];
            }
            for (int k =0; k < secondArray.Length; k ++)
            {
                currentElementSA = secondArray[k];
            }
            if(currentElementFA != currentElementSA)
            {
                areMatching = false;
            }
            Console.Write("Are the two arrays matching? {0}", areMatching);*/

           /* Console.Write("Enter the numbers in your array: ");
            string arrayNumbers = Console.ReadLine();
            string[] numberArray = arrayNumbers.Split(" ");
            int bestStart = 0;
            int bestLen = 1;
            int start = 0;
            int len = 1;

            for (int index = 1; index < numberArray.Length; index++)
            {
                int startEl;
                int currentElement;
                int.TryParse(numberArray[start], out startEl);
                int.TryParse(numberArray[index], out currentElement);

                if (currentElement == startEl)
                {
                    len++;

                }
                else if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                    start = index;
                    len = 1;
                }
                else
                {
                    start = index;
                    len = 1;
                }
            }

            Console.WriteLine(bestLen + " " + bestStart);*/

        }
    }
}
