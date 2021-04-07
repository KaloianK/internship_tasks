using System;
using System.Threading;
using System.Globalization;

namespace StringifyEquation
{
    class StringifyEquation
    {
        static int[] AllPossibleNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static char[] AllCharactersPossible = new char[] { '%', '^', '*', '(', ')', '-', '=', '+', '/', '.', ',' };

        static void FindOpeningBracket(string equation)
        {
            string openingBracket = '('.ToString();
            string closingBracket = ')'.ToString();
            string currentElement;
            string emptySpace = ' '.ToString();

            for (int i = 0; i < equation.Length; i++)
            {
                currentElement = equation[i].ToString();

                if (String.Equals(currentElement, emptySpace))
                {
                    continue;
                }

                if (String.Equals(openingBracket, currentElement) || String.Equals(closingBracket, currentElement))
                {
                    Console.WriteLine("There is a bracket at {1} position!", openingBracket, i);
                    PushIndexOfOpeningBracket(equation, i);
                }
                else
                {
                    Console.WriteLine("Here stays neither opening bracket '{0}' nor closing bracket '{1}' at {2} position!", openingBracket, closingBracket, i);
                }
            }
        }

        static void PushIndexOfOpeningBracket(string equation, int i)
        {
            int k = 0;
            int[] arrayWithOpeningBrackets = new int[equation.Length];
            arrayWithOpeningBrackets[k] = i;
            Console.Write(arrayWithOpeningBrackets[k] + " ");
            k++;

        }



        static void Main(string[] args)
        {
            Console.Write("Enter the equation you want to stringify and calculate: ");
            string equation = Console.ReadLine();
            string[] splitCharacters = equation.Split(' ');
            double[] numbers = new double[splitCharacters.Length];
            char[] characters = new char[splitCharacters.Length];
            FindOpeningBracket(equation);

        }
    }
}
