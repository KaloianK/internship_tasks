using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class StudentProblem
    {
        private string threeNames;
        //full name
        //first name
        // last name
        private int year;
        private string course;
        private string university;
        private string mail;
        private int phoneNumber;
        public static int counter = 0;

        public StudentProblem(string threeNames, int year, string course, string university, string mail, int phoneNumber)
        {
            this.threeNames = threeNames;           
            this.year = year;
            this.course = course;
            this.university = university;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            counter++;
        }
        //public string fullNames
        //{
        //    get
        //    {
        //        return firstName + " " + lastName
        //    }
        //}
        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value + 100;
            }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student's three names are: " + this.threeNames + ". He is year" + this.year + ". His course is called: " + this.course + (" in the " + this.university) +
                 ". His mail is: " + this.mail + " and has Phone Number like this: 0" + this.phoneNumber);
            Console.WriteLine(counter);
        }

       

    }
}
