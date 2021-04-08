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
        static string OpeningBracket = '('.ToString();
        static string ClosingBracket = ')'.ToString();
        static string CurrentElement;
        static string NextElement;
        static string EmptySpace = ' '.ToString();
        // static int Index = 0;
        static string[] ArrayForSubSums;
        static int Sum;
        static string allOperands = "*, /, +, -";
        static string equation;
        static int i = 0;
        static void CalculateSumsInEquation(string equation, int index)
        {

            while (index < equation.Length - 1)
            {
                if (String.Equals(equation[index], '('))
                {
                    Sum += CalculateSumBetweenBrackets(index);
                }
                index++;
                //if (index + 1 >= equation.Length)
                //{
                //    return;
                //}
                //CurrentElement = equation[index].ToString();
                //NextElement = equation[index + 1].ToString();

                //if (String.Equals(CurrentElement, EmptySpace))
                //{
                //    CalculateSumsInEquation(equation, index + 1);
                //    return;
                //}

                //if (!String.Equals(NextElement, ClosingBracket))
                //{
                //    if (String.Equals(CurrentElement, OpeningBracket) && !String.Equals(NextElement, OpeningBracket))
                //    {
                //        ArrayForSubSums[index] = NextElement;
                //        // SumBetweenTwoBrackets(equation, index);
                //        SumArrayBetweenTwoBrackets(ArrayForSubSums, 0);



                //    }
                //    else
                //    {
                //        CalculateSumsInEquation(equation, index + 1);
                //        return;
                //    }


                //}
                //if (String.Equals(NextElement, ClosingBracket))
                //{

                //    //index += 1;
                //    //CalculateSumsInEquation(equation, index);
                //    return;

                //}

                //return;
            }
            Console.Write(Sum);
        }
        static int CalculateSumBetweenBrackets(int index)
        {
            //print opening bracket
            Console.Write(equation[index]);
            //Increase Index
            index++;
            //Check for Opening Bracket
            if (String.Equals(equation[index], '('))
            {
                CalculateSumBetweenBrackets(index + 1);
            }
            //If true --> call recursion
            //Check for Closing Bracket
            if (String.Equals(equation[index], ')'))
            {
                SumArrayBetweenTwoBrackets(ArrayForSubSums);
                Console.Write(")");
                return index;

            }
            //if true--->print and return

            //Add current symbol to an array
            ArrayForSubSums[i] = equation[index].ToString();
            i++;
            //Call Another Method

            return SumArrayBetweenTwoBrackets(ArrayForSubSums);
        }


        static int SumArrayBetweenTwoBrackets(string[] arrayWithSubSums)
        {
            int leftNumber = 0;
            int rightNumber = 0;
            int currentSum = 0;
            int lastRightNumber = 0;
            for (int i = 1; i < arrayWithSubSums.Length; i += 2)
            {

                if (arrayWithSubSums[i] == "*")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber * rightNumber;
                    // Console.Write(Sum);

                }
                if (arrayWithSubSums[i] == "/")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber / rightNumber;
                    // Console.Write(Sum);

                }
                if (arrayWithSubSums[i] == "+")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber + rightNumber;
                   
                    //Console.Write(Sum);

                }
                if (arrayWithSubSums[i] == "-")
                {
                    int.TryParse(arrayWithSubSums[i - 1], out leftNumber);
                    int.TryParse(arrayWithSubSums[i + 1], out rightNumber);
                    currentSum = leftNumber - rightNumber;
                    //Console.Write(Sum);

                }
                Sum += currentSum - lastRightNumber;
                lastRightNumber = rightNumber;
            }
            return Sum;  
        }


        static void Main()
        {
            Console.Write("Enter the equation you want to stringify and calculate: ");
            equation = Console.ReadLine();
            ArrayForSubSums = new string[equation.Length];
            CalculateSumsInEquation(equation, 0);
        }
    }
}
