using System;
using System.Text;


namespace ObjectsAndClasses
{
   

    public class Cat
    {
        //Field Name
        private string name;
        //Field Color
        private string color;
        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }
        //Default Construction
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "Grey";
        }
        //Construction With Parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauu", name);
        }
        public static void CatFunc()
        {
            Cat firstCat = new Cat();
            firstCat.name = "Tony";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pepy", "Red");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1}", secondCat.Name, secondCat.color);

            int sum = 0;
            int startTime = Environment.TickCount;

            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }
            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);

            Random rand = new Random();

            for (int number = 1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }


            // Problem 10 in the book's poblems

            Console.Write("Enter the numbers you want to sum: ");
            string numbers = Console.ReadLine();

            string[] splitNumbers = numbers.Split(' ');

            double[] arrayWithSplitNumbers = new double[splitNumbers.Length];

            for (int i = 0; i < splitNumbers.Length; i++)
            {
                double.TryParse(splitNumbers[i], out arrayWithSplitNumbers[i]);
            }

            double sumOfSplit = 0;

            for (int i = 0; i < arrayWithSplitNumbers.Length; i++)
            {
                sumOfSplit += arrayWithSplitNumbers[i];

            }
            Console.Write("The sum of your numbers is: {0} ", sum);
        }



    }

}
