using System;

namespace MethodsProblems
{
    class MethodsProblems
    {
        /*1
          static string PrintName(string name)
        {
            Console.Write("Hello, {0}!", name);
            return name;
        }*/

        /* 2
          static int GetMax(int firstNumber, int secondNumber)
          {
              return firstNumber > secondNumber ? firstNumber : secondNumber;

          }
          static int MaxOfThree(int biggerNumber, int thirdNumber)
          {
              return biggerNumber > thirdNumber ? biggerNumber : thirdNumber;
          }*/
      


        static void Main(string[] args)
        {
            //1 PrintName("Kaloian");

            /*2 
              Console.Write("Enter three numbers: ");
              string number = Console.ReadLine();
              string[] splitNumbers = number.Split(' ');
              int firstNumber;
              int.TryParse(splitNumbers[0], out firstNumber);
              int secondNumber;
              int.TryParse(splitNumbers[1], out secondNumber);
              int thirdNumber;
              int.TryParse(splitNumbers[2], out thirdNumber);
              Console.WriteLine("The biggest number of them all is: " + MaxOfThree(GetMax(firstNumber, secondNumber), thirdNumber));*/

           


        }
    }
}
