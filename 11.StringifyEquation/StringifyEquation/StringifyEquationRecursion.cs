using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace StringifyEquation
{
    class StringifyEquationRecursion
    {

        // static int Index = 0;
        static string[] arrayOfNumbersAndOperators;
        static int Sum = 0;
        static string equation;
        static int i = 0;
        static int Index = 0;       
        static int[] arrayForSubSums;
        static int k = 0;
        static void CalculateSumsInEquation(string equation)
        {

            while (Index < equation.Length - 1)
            {

                if (String.Equals(equation[Index], '('))
                {
                    Sum += CalculateSumBetweenBrackets(Index).Sum;
                }
                Index++;
            }
            Console.Write(Sum);
        }
        static SumAndIndexOfRecursion CalculateSumBetweenBrackets(int index)
        {

            //print opening bracket
            // Console.Write(equation[index]);
            //Increase Index
            index++;
            //Check for Opening Bracket
            SumAndIndexOfRecursion a = new SumAndIndexOfRecursion(Sum, index);


            if (String.Equals(equation[index], '('))
            {
                Console.Write("(");
                a = CalculateSumBetweenBrackets(index);
                index = a.index;

            }
            //If true --> call recursion
            //Check for Closing Bracket

            if (String.Equals(equation[index], ')'))
            {
                //SumArrayBetweenTwoBrackets(arrayOfNumbersAndOperators);
                Console.Write(a.Sum);
                Console.Write(")");
                return a;

            }
            //if true--->print and return

            //Add current symbol to an array
            index = PushNumbersAndOperatorsInArray(arrayOfNumbersAndOperators, index);
            //Call Another Method
            int newSum = SumArrayBetweenTwoBrackets(arrayOfNumbersAndOperators);
            SumAndIndexOfRecursion getSumAndIndex = new SumAndIndexOfRecursion(newSum, index);
            return getSumAndIndex;
        }

        static int PushNumbersAndOperatorsInArray(string[] arrayOfNumbersAndOperators, int index)
        {
            while (index < arrayOfNumbersAndOperators.Length && i < arrayOfNumbersAndOperators.Length && !String.Equals(equation[index], ')'))
            {
                arrayOfNumbersAndOperators[i] = equation[index].ToString();
                i++;
                index++;

            }
            i = 0;
            return index;
        }


        static int SumArrayBetweenTwoBrackets(string[] arrayWithSubSums)
        {
            int leftNumber = 0;
            int rightNumber = 0;
            int currentSum = 0;
           
            for (int i = 1; i < arrayWithSubSums.Length; i += 2)
            {

                if (arrayWithSubSums[i] == "*")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber * rightNumber;
                }
                if (arrayWithSubSums[i] == "/")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber / rightNumber;
                }
                if (arrayWithSubSums[i] == "+")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber + rightNumber;
                }
                if (arrayWithSubSums[i] == "-")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber - rightNumber;                   
                }

            }
            SubSumsInArray(arrayForSubSums, currentSum, k);
            currentSum = 0;
            Array.Clear(arrayOfNumbersAndOperators, 0, arrayOfNumbersAndOperators.Length);
            return arrayForSubSums[i];
        }
        static int SubSumsInArray(int[] arrayForSubSums,int currentSum, int k)
        {
            arrayForSubSums[i] = currentSum;
            k++;
            return currentSum;
        }


        static void Main()
        {
            Console.Write("Enter the equation you want to stringify and calculate: ");
            equation = Console.ReadLine();
            arrayOfNumbersAndOperators = new string[equation.Length];
            arrayForSubSums = new int[equation.Length];
            //SumAndIndexOfRecursion getSumAndIndex = new SumAndIndexOfRecursion(Sum, Index);
            CalculateSumsInEquation(equation);
            // (2+2)*(((3+4)+1)/2)
        }
    }
}
