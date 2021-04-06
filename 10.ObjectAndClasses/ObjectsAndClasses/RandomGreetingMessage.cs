using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectsAndClasses
{
    public class RandomGreetingMessage
    {
        private static string[] GreetingPhrase = { "Product is perfect.", "This is absolute perfect product.", "I use this product all the time.", "This is the best product in its category." };
        private static string[] HappyOutcome = { "I am feeling better already.", "It changed me.", "It made a miracle.", "I cant believe how good i feel when i use it.", "Try it yourself! I am very satisfied." };
        private static string[] FirstName = { "Esther", "Karen", "Elena", "Katherine", "Dahlia" };
        private static string[] LastName = { "Jones", "Pierce", "Saltzman" };
        private static string[] NameOfCity = { "London", "New Orleans", "Veliko Tarnovo", "Dubai", "Paris" };

        private static Random randomMessage = new Random();
        public static void RandomGreetingMessageFunc()
        {
            string greeting = GreetingPhrase[randomMessage.Next(0, GreetingPhrase.Length)];
            string outcome = HappyOutcome[randomMessage.Next(0, HappyOutcome.Length)];
            string firstName = FirstName[randomMessage.Next(0, FirstName.Length)];
            string lastName = LastName[randomMessage.Next(0, LastName.Length)];
            string cityName = NameOfCity[randomMessage.Next(0, NameOfCity.Length)];

            Console.Write(greeting + " " + outcome + " -- " +firstName + " " +lastName + ", " + cityName);


        }

    }

}
