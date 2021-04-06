using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    public class GettingHypotenuseValue
    {

        private static double Hypotenuse;

        public static void GettingHypotenuseValueFunc()
        {
            Console.Write("Enter the length of the first cathetus: ");
            double firstCathetus = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the second cathetus: ");
            double secondCathetus = double.Parse(Console.ReadLine());

            Hypotenuse = Math.Sqrt(Math.Pow(firstCathetus, 2) + Math.Pow(secondCathetus, 2));
            Console.WriteLine("The length of the hypotenuse is: {0}", Hypotenuse);
        }
    }
}
