using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class StudentProblem
    {
        private string firstName;
        private string lastName;
        private int year;
        private string course;
        private string university;
        private string mail;
        private int phoneNumber;
        public static int counter = 0;

        public StudentProblem(string firstName, string lastName, int year, string course, string university, string mail, int phoneNumber)
        {

            this.year = year;
            this.course = course;
            this.university = university;
            this.mail = mail;
            this.phoneNumber = phoneNumber;
            this.firstName = firstName;
            this.lastName = lastName;

          
            counter++;
        }



        public StudentProblem(string firstName, string lastName)
        {

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                firstName = value;
                if (firstName == "")
                {
                    throw new ArgumentNullException("You didn't enter your First Name. Please try again!");

                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                lastName = value;

                if (lastName == "")
                {
                    throw new ArgumentNullException("You didn't enter your Last Name. Please try again!");

                }
            }
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }

        }

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

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                course = value;
            }
        }

        public string University
        {
            get
            {
                return this.university;
            }
            set
            {
                university = value;
                if (university == "")
                {
                    throw new ArgumentNullException("You didn't enter your University. Please try again!");

                }
            }
        }

        public string Email
        {
            get
            {
                return this.mail;
            }
            set
            {
                mail = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                year = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student's names are: " + this.FullName + ". He is year " + this.Year + ". His course is called: " + this.Course + (" in the " + this.University) +
                 ". His mail is: " + this.Email + " and has Phone Number like this: 0" + this.PhoneNumber);
            Console.WriteLine(counter);
        }



    }
}
