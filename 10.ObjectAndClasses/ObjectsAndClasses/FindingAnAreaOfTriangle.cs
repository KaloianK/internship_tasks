using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    public class FindingAnAreaOfTriangle
    {
        private static double FirstSide;
        private static double SecondSide;
        private static double ThirdSide;
        private static double HeightOfOneSide;
        private static double AngleInDegrees;

        public static void FindingAnAreaOfTriangleFunc()
        {
            Console.Write("Enter the length of first side: ");
            FirstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of second side: ");
            SecondSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of third side: ");
            ThirdSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the degrees of the angle between third and second side: ");
            AngleInDegrees = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the height of first side: ");
            HeightOfOneSide = double.Parse(Console.ReadLine());

            double HalfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            double formulaOfHeronForFindingTheArea = Math.Sqrt(HalfPerimeter * (HalfPerimeter - FirstSide) * (HalfPerimeter - SecondSide) * (HalfPerimeter - ThirdSide));
            double areaWithSideAndHeight = (FirstSide * HeightOfOneSide) / 2;
            int areaWithTwoSidesAndAngleInbetween = (int)((ThirdSide * SecondSide * Math.Sin(AngleInDegrees)) / 2);

            Console.WriteLine("The area of the triangle using three sides is: {0}", formulaOfHeronForFindingTheArea);
            Console.WriteLine("The area of the triangle using first side and the heigth towards it is: {0}", areaWithSideAndHeight);
            Console.WriteLine("The area of the triangle using third and second side and the angle inbetween is: {0}", areaWithTwoSidesAndAngleInbetween);


        }
    }
}
