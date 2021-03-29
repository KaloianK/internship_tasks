using System;

namespace StringifyNumbers
{
    class StringifyNumbers
    {
        static string GetSingular(int singular)
        {
            string[] singularArray = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            return singularArray[singular];
        }

        static string GetDecimals(int decimals, int singulars)
        {
            string result;
            if (decimals == 1)
            {
                switch (decimals + singulars)
                {
                    case 1: result = "Ten"; break;
                    case 2: result = "Eleven"; break;
                    case 3: result = "Twelve"; break;
                    case 4: result = "Thirteen"; break;
                    case 6: result = "Fifteen"; break;
                    case 9: result = "Eighteen"; break;
                    default: result = GetSingular(singulars) + "teen"; break;
                }
            }
            else
            {
                switch (decimals)
                {
                    case 0: result = ""; break;
                    case 2: result = "Twenty"; break;
                    case 3: result = "Thirty"; break;
                    case 5: result = "Fifty"; break;
                    case 8: result = "Eighty"; break;
                    default: result = GetSingular(decimals) + "ty"; break;
                }
            }


            return result;
        }

        static string GetHundreds(int hundreds)
        {
            return hundreds != 0 ? GetSingular(hundreds) + "-hundred" : "";
        }

        static void Main(string[] args)
        {


            Console.Write("Enter a number between 1 and 1000: ");
            string input = Console.ReadLine();
            int numbers = int.Parse(input);
            int[] numArray = new int[4];
            int lastDigit;
            int number = numbers;

            for (int i = 0; i < 4; i++)
            {
                lastDigit = numbers % 10;
                numArray[i] = lastDigit;
                numbers /= 10;
            }
            int singulars = numArray[0];
            int decimals = numArray[1];
            int hundreds = numArray[2];
            string result = "";

            if (number == 0)
            {
                result = GetSingular(singulars);
            }
            else if (number == 1000)
            {
                result = "One Thousand!";
            }
            else if (number > 1000)
            {
                result = "Number out of reach!  :(";
            }         
            else
            {
                if (hundreds != 0)
                {
                    result = GetHundreds(hundreds);
                }

                if (decimals != 0)
                {
                    if (hundreds != 0)
                    {
                        result += " and ";
                    }

                    result += GetDecimals(decimals, singulars);
                }

                if (decimals != 1 && singulars != 0)
                {
                    if (hundreds != 0 && decimals == 0)
                    {
                        result += " and ";
                    }

                    result += GetSingular(singulars);
                }
            }

            Console.Write(result);
        }
    }
}
