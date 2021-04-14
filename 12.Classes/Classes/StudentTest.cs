using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class StudentTest
    {
        static void Main()
        {
            
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

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

            

            StudentProblem student1 = new StudentProblem(firstName, lastName, year, course, university, mail, phoneNumber);
            student1.FirstName = firstName;
            student1.LastName = lastName;
            student1.Year = year;
            student1.Course = course;
            student1.University = university;
            student1.Email = mail;
            student1.PhoneNumber = phoneNumber;
            student1.PrintStudentInfo();
            
            Console.WriteLine("First Name: " + student1.FirstName);
            Console.WriteLine("Last Name: " + student1.LastName);
            Console.WriteLine("Full Name: " + student1.FullName);
            Console.WriteLine("Years of studying: " + student1.Year);
            Console.WriteLine("Course: " + student1.Course);
            Console.WriteLine("Uni: " + student1.University);
            Console.WriteLine("Mail: " + student1.Email);
            Console.WriteLine("Phone Number: " + student1.PhoneNumber);


            StudentProblem student2 = new StudentProblem(firstName, lastName, year, course, university, mail, phoneNumber);
            student2.PrintStudentInfo();

            Console.WriteLine("The number of students is: " + student2.Counter);

            student2.Counter = 4;
            
            Console.WriteLine("The number of students is: " + student2.Counter);
        }
    }
}
