using System;

namespace OperatorsAndExpressions
{
    class OperatorsAndExpressions
    {
        static void Main(string[] args)
        {
            /* int a = 6;
            int b = 3;
            Console.WriteLine(a + b / 2);                   
            Console.WriteLine((a + b) / 2);                  
            string s = "Beer";
            Console.WriteLine(s is string);                  
            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");  
            Console.WriteLine(notNullString ?? "Specified");
           */
            //-----------------------------------------------------
            /*int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[0]); 
            string str = "Hello";
            Console.WriteLine(str[1]); 
            */
            //-----------------------------------------------------
            /*
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a>b" : "b<=a");
            int num = a == b ? 1 : -1;
            */
            //--------------------------------------------------------
            /* int squarePerimeter = 17;
             double squareSide = squarePerimeter / 4.0;
             double squareArea = squareSide * squareSide;
             Console.WriteLine(squareSide); // 4.25
             Console.WriteLine(squareArea); // 18.0625
             int a = 5;
             int b = 4;
             Console.WriteLine(a + b);      
             Console.WriteLine(a + b++);    
             Console.WriteLine(a + b);      
             Console.WriteLine(a + (++b));  
             Console.WriteLine(a + b);      
             Console.WriteLine(14 / a);     
             Console.WriteLine(14 % a);     
             int one = 1;
             int zero = 0;
             double dMinusOne = -1.0;
             double dZero = 0.0;
             Console.WriteLine(dMinusOne / zero); 
             Console.WriteLine(one / dZero); 
            */
            //-----------------------------------------------------------
            /*int isPrime = 16;
            if (isPrime % 2 == 0)
            {
                Console.WriteLine(isPrime + " " + "is Prime.");
            }
            else
            {
                Console.WriteLine(isPrime + " " + "is not Prime");
            }
            */
            /*bool isDivided = false;
            int num = 36;
            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine(!isDivided);
            }
            else
            {
                Console.WriteLine(isDivided);
            }
            */
            /*int num = 90;
            bool isSeven = true;
            int thirdDigit = (num / 100) % 10;
            if (num < 100)
            {
                Console.WriteLine("Number does not meet the requirements!");
            }
            else if (thirdDigit == 7)
            {
                Console.WriteLine(isSeven + " - The third digit from right to left is 7!");
            }
            else
            {
                Console.WriteLine(!isSeven + " - The third digit from right to left is not 7!");
            }
            */
            /*byte num = 5;
            int thirdByte = num % 10;
            bool isOne = true;
            if (thirdByte == 1)
            {
                Console.WriteLine(isOne + " - The third Byte is 1!");
            }
            else
            {
                Console.WriteLine(!isOne + " - The third Byte is not 1, it is 0!");
            }
            */
            /*int a, b, h;
            a = 5;
            b = 7;
            h = 4;
            int areaTrapec = (a + b) * h / 2;
            Console.WriteLine(areaTrapec);
            */
            /* int length = 15;
             int width = 4;
             int perimeter = length + width;
             int area = length * width;
             Console.WriteLine(perimeter + " " + area);
            */
            /*Console.Write("Enter your mass on the Earth: ");
            decimal massOnEarth = Convert.ToDecimal(Console.ReadLine());
            float massOnMoon = (float)massOnEarth * 17 / 100;
            Console.WriteLine(massOnMoon);
              */
            /*int r = 5;
            int x = 2;
            int y = 6;
            int pitagor = x * x + y * y;
            if(pitagor <= (r * r))
            {
                Console.WriteLine("The point is in hte circle!");
            }
            else
            {
                Console.WriteLine("The point is not in the circle!");
            }
            */
            /*Console.Write("Enter a 4-digit number: ");
            int fourDigitNumber = Convert.ToInt32(Console.ReadLine());
            if(fourDigitNumber < 1000 || fourDigitNumber > 9999)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                int e = fourDigitNumber % 10;
                int d = (fourDigitNumber / 10) % 10;
                int s = (fourDigitNumber / 100) % 10;
                int h = fourDigitNumber / 1000;
                int sum = e + d + s + h;
                Console.WriteLine(sum);
                Console.WriteLine(e + " " + d + s + h);
                Console.WriteLine(e + " " + h + s + d);
                Console.WriteLine(h + " " + d + s + e);

            }
            */
            /*byte n = 35;
            int p = 6;
            int i = 1;
            int number = i << p;
            Console.WriteLine((n & number) != 0 ? 1 : 0);
            */
            /*Console.Write("Enter a number between 1 and 100: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (n < 1 || n >= 100)
            {
                Console.WriteLine("Invalid NUmber!");
            }
            else if (n == 1)
            {
                isPrime = true;
                
            }
            else
            {
                for(int i = 2; i < (n / 2); i ++)
                {
                    if(n % i == 0)
                    {
                        isPrime = false;                                                                    
                    } 
                }
            }
            Console.WriteLine(isPrime);

            */
            /*string name = "Kaloyan";
            int age = 22;
            string town = "Veliko Tarnovo";
            Console.Write("{0} is {1} years old and is from {2}", name, age, town);
            */
            /*Console.WriteLine("{0,6}", 123);
            Console.WriteLine("{0,-6}", 14234);
            Console.WriteLine("{0,6}", 12);
            */
            /* Console.WriteLine("{0:C2}", 123.456);
             //Output: 123,46 лв.
             Console.WriteLine("{0:D6}", -1234);
             //Output: -001234
             Console.WriteLine("{0:E2}", 123);
             //Output: 1,23Е+002
             Console.WriteLine("{0:F2}", -123.456);
             //Output: -123,46
             Console.WriteLine("{0:N2}", 1234567.8);
             //Output: 1 234 567,80
             Console.WriteLine("{0:P}", 0.456);
             //Output: 45,60 %
             Console.WriteLine("{0:X}", 254);
             //Output: FE
             Console.WriteLine("{0:0.00}", 1);
             //Output: 1,00
             Console.WriteLine("{0:#.##}", 0.234);
             //Output: ,23
             Console.WriteLine("{0:#####}", 12345.67);
             //Output: 12346
             Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
             //Output: (02) 934 25 25
             Console.WriteLine("{0:%##}", 0.234);
             //Output: %23
            */

            /*DateTime date = new DateTime(2020, 5, 27, 8, 17, 34);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", date);
            Console.WriteLine("{0:d.MM.yy r.}", date);
            */
            /* DateTime d = new DateTime(2009, 10, 23, 15, 30, 22);
             Thread.CurrentThread.CurrentCulture =
             CultureInfo.GetCultureInfo("en-US");
             Console.WriteLine("{0:N}", 1234.56);
             Console.WriteLine("{0:D}", d);
             Thread.CurrentThread.CurrentCulture =
             CultureInfo.GetCultureInfo("bg-BG");
             Console.WriteLine("{0:N}", 1234.56);
             Console.WriteLine("{0:D}", d);
            */
            /*Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your second name: ");
            string secondName = Console.ReadLine();
            Console.Write("ENter your last name: ");
            string lastName = (Console.ReadLine());
            Console.WriteLine("Hello, {0} {1} {2}", firstName, secondName, lastName);
            */
            /*Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("({0} + {1}) * {0} / {2} = {3}", a, b, c, (a + b) * a / c);
            */
            /*ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Admin entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);
            */
            /*Console.Write("Enter person name: ");
            string person = Console.ReadLine();
            Console.Write("Enter book name: ");
            string book = Console.ReadLine();
            string from = "Authors Team";
            Console.WriteLine("Dear {0},", person);
            Console.Write("We are pleased to inform " +
            "you that \"{1}\" is the best Bulgarian book. {2}" +
            "The authors of the book wish you good luck {0}!{2}",
            person, book, Environment.NewLine);
            Console.WriteLine("Yours,");
            Console.WriteLine("{0}", from);
            */
        }
    }
}
