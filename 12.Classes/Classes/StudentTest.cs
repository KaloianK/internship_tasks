using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class StudentTest
    {
        static void Main()
        {

            Console.Write("Enter your three names: ");
            string threeNames = Console.ReadLine();
            Console.Write("Enter your year of studying: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter your course: ");
            string course = Console.ReadLine();
            Console.Write("Enter the University you are currently studying in: ");
            string university = Console.ReadLine();
            Console.Write("Enter your E-mail address: ");
            string mail = Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            int phoneNumber = int.Parse(Console.ReadLine());

            StudentProblem student1 = new StudentProblem(threeNames, year, course, university, mail, phoneNumber);
            StudentProblem student2 = new StudentProblem(threeNames, year, course, university, mail, phoneNumber);

            student1.PrintStudentInfo();
            student2.PrintStudentInfo();

            Console.WriteLine("The number of students is: " + student2.Counter);

            student2.Counter = 4;

            Console.WriteLine("The number of students is: " + student2.Counter);
        }
    }
}
