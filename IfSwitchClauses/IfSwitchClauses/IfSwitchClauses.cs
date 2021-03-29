using System;

namespace IfSwitchClauses
{
    class IfSwitchClauses
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("char 'a' == 'b' ? " + ('a' == 'b'));*/
            /*int first = 23;
            int second = 5;
            if (first == second)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else if (first > second)
            {
                Console.WriteLine("The First number is greater than the second!");
            }
            else
            {
                Console.WriteLine("The Second number is greater than the first!");
            }
            */
            /*int number = 7;
            switch(number)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("This number is not Prime!"); break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("This Number is Prime!"); break;
                default:
                    Console.WriteLine("I dont know what is this number!!"); break;
            }*/
            /* Console.Write("Enter the first number: ");
             int firstNumber = int.Parse(Console.ReadLine());
             Console.Write("Enter the second number: ");
             int secondNumber = int.Parse(Console.ReadLine());
             int swappedNumber;
             if (firstNumber > secondNumber)
             {
                 swappedNumber = firstNumber;
                 firstNumber = secondNumber;
                 Console.WriteLine("The numbers were swapped! " + firstNumber + " " + swappedNumber);
             }
             else
             {
                 Console.WriteLine("The numbers were not swapped! " + firstNumber + " " + secondNumber);
             }
            */
            /*Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if((firstNumber * secondNumber * thirdNumber ) >= 0)
            {
                Console.WriteLine("The multiplication of the three numbers leads to a '+' sign! :)");
            }
            else
            {
                Console.WriteLine("The multiplication of the three numbers leads to a '-' sign! :(");
            }
            */
            /*Console.Write("Enter a number between 1-9: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("One"); break;
                case 2:
                    Console.WriteLine("Two"); break;
                case 3:
                    Console.WriteLine("Three"); break;
                case 4:
                    Console.WriteLine("Four"); break;
                case 5:
                    Console.WriteLine("Five"); break;
                case 6:
                    Console.WriteLine("Six"); break;
                case 7:
                    Console.WriteLine("Seven"); break;
                case 8:
                    Console.WriteLine("Eight"); break;
                case 9:
                    Console.WriteLine("Nine"); break;
                default:
                    Console.WriteLine("This number is out of my knowledge! :)"); break;

            }
            */
            /*Console.WriteLine("Enter 'a', 'b' and 'c' for 'ax^2 + bx + c':");
            Console.Write("Insert 'a' = ");
            double readA = double.Parse(Console.ReadLine());
            Console.Write("Insert 'b' = ");
            double readB = double.Parse(Console.ReadLine());
            Console.Write("Insert 'c' = ");
            double readC = double.Parse(Console.ReadLine());
            double diskr = readB * readB - 4 * readA * readC;
            double rootOne = (- readB + Math.Sqrt(diskr)) / 2 * readA;
            double rootTwo = (- readB - Math.Sqrt(diskr)) / 2 * readA;
            if (diskr == 0)
            {
                rootOne = rootTwo = (-readB) / (2 * readA);
                Console.WriteLine("The Discriminant equals 0 so the roots are equal: " + rootOne);
            }
            else if(diskr > 0)
            {
                Console.WriteLine("The Discriminant equals {0} so there are 2 roots: {1} and {2}", diskr, rootOne, rootTwo);
            }
            else
            {
                Console.WriteLine("The Discriminant equals less than 0 so there are no roots! :(");
            }

            */

            /*Console.Write("Insert Something Here: ");       
            string stringText = Console.ReadLine();
            int intNumber;
            double doubleNumber;
            if (int.TryParse(stringText, out intNumber))
            {
                Console.WriteLine(++intNumber);
            }
            else if (double.TryParse(stringText, out doubleNumber))
            {
                Console.WriteLine(++doubleNumber);
            }
            else
            {
                Console.WriteLine(stringText + "*");
            }
           */

        }
    }
}
