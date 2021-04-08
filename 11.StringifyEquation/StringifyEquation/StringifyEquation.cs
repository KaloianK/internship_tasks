using System;
using System.Threading;
using System.Globalization;

//             (2+2) * (((3+4) + 1) / 2)

namespace StringifyEquation
{
    class StringifyEquation
    {
        static int[] AllPossibleNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static char[] AllCharactersPossible = new char[] { '%', '^', '*', '(', ')', '-', '=', '+', '/', '.', ',' };
        static int StartBracket;
        static int EndBracket;
        static int[] ArrayWithOpeningBrackets;
        static int[] ArrayWithClosingBrackets;
        static int k = 0;
        static int l = 0;
        static void FindOpeningOrClosingBracketByIndex(string equation)
        {
            string openingBracket = '('.ToString();
            string closingBracket = ')'.ToString();
            string currentElement;
            string emptySpace = ' '.ToString();
            ArrayWithOpeningBrackets = new int[equation.Length];
            ArrayWithClosingBrackets = new int[equation.Length];

            for (int i = 0; i < equation.Length; i++)
            {
                currentElement = equation[i].ToString();

                if (String.Equals(currentElement, emptySpace))
                {
                    continue;
                }

                if (String.Equals(openingBracket, currentElement))
                {
                    PushIndexOfOpeningBracket(equation, i);
                }

                if (String.Equals(closingBracket, currentElement))
                {
                    PushIndexOfClosingBracket(equation, i);
                }

            }
        }

        static void PushIndexOfOpeningBracket(string equation, int i)
        {
            
            
            ArrayWithOpeningBrackets[k] = i;
            Console.WriteLine(ArrayWithOpeningBrackets[k]);
            k++;

            

        }

        static void PushIndexOfClosingBracket(string equation, int m)
        {
            
            
            
            ArrayWithClosingBrackets[l] = m;
            Console.WriteLine(ArrayWithClosingBrackets[l]);
            l++;
        }

        static void FindPairOfBrackets(int l, int m)
        {
            int openingBracket;
            int closingBracket;
            for (int i = l; i < ArrayWithOpeningBrackets.Length - 1; i++)
            {
                openingBracket = ArrayWithOpeningBrackets[i];
                for (int k = m; k < ArrayWithClosingBrackets.Length; k++)
                {
                    closingBracket = ArrayWithClosingBrackets[k];
                    if (ArrayWithOpeningBrackets[i + 1] > closingBracket)
                    {

                        StartBracket = openingBracket;
                        EndBracket = closingBracket;
                    }

                }
            }
            Console.WriteLine("Opening bracket is at {0} position and its closing bracket is at {1} position", StartBracket, EndBracket);

        }

        static void FindTheSubEqutionBetweenTheStartEndBracket(int startBracket, int endBracket)
        {
            for (int i = startBracket + 1; i < endBracket; i++)
            {

            }
        }




        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the equation you want to stringify and calculate: ");
        //    string equation = Console.ReadLine();
        //    ArrayWithOpeningBrackets = new int[equation.Length];
        //    ArrayWithClosingBrackets = new int[equation.Length];
        //    FindOpeningOrClosingBracketByIndex(equation);
        //    FindPairOfBrackets(0, 0);
        //    // (2+2) * (((3+4) + 1) / 2)
        //}
    }
}
