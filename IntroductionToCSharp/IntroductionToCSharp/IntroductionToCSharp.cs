using System;

namespace IntroductionToCSharp
{
    class IntroductionToCSharp
    {
        static void Main(string[] args)
        {
            //DAY2?????????????????????????????????????????????????????????????
            /*int a = 2;
            int b = 2;
            bool isGreater = (a > b);
            if (isGreater)
            {
                Console.WriteLine("A is greater (A > B)!");
            }
            else
            {
                Console.WriteLine("B is greater or equal (A <= B)");
            }
           */
            //-----------------------------------------------------------
            /*char symbol = 'F';
            Console.WriteLine("The Code of '" + symbol + "' is:" + (int)symbol);*/
            //-----------------------------------------------------------
            /*string firstName = "Kaloyan";
            string lastName = "Karaivanov";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Hello " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");
            */
            //------------------------------------------------------------
            /*int i = -2;
            int? ni = i;
            Console.WriteLine(ni);
            Console.WriteLine(ni.HasValue);
            i = ni.Value;
            Console.WriteLine(i);
            ni = null;
            Console.WriteLine(ni.HasValue);
            i = ni.GetValueOrDefault();
            Console.WriteLine(i);
            */
            //------------------------------------------------------------
            /*string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            Console.WriteLine(helloWorld);
            */
            //------------------------------------------------------------
            /*bool isMale = true;
             Console.Write("What is your gender? (Type m for male or f for female)" + "\n");
             char myChar = Console.ReadKey().KeyChar;
             if (myChar == 'f' || myChar == 'F')
             {
                 Console.WriteLine(!isMale);
             }
             else if (myChar == 'm' || myChar == 'M')
             {
                 Console.WriteLine(isMale);
             }
             else
             {
                 Console.WriteLine("You entered non exisiting gender!!");
             }
            */
            //--------------------------------------------------------------

        }
    }
}
