using System;

namespace DrinkBook
{
    public class DrinkBook
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string inputName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int inputAge = int.Parse(Console.ReadLine());
            Console.Write("Enter your budget: ");
            int inputBudget =int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of Whiskeys you want to drink: ");
            int inputDrinkableWhiskeys =int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of Vodkas you want to drink: ");
            int inputDrinakbleVodkas = int.Parse(Console.ReadLine());
            Console.Write("Enter the music you prefer to listen (Folk, Rock, House, Everything): ");
            string inputPreferredMusic = Console.ReadLine();

            User clubGod = new User(inputName, inputAge, inputBudget, inputDrinkableWhiskeys, inputDrinakbleVodkas, inputPreferredMusic);
            
            //clubGod.AddToFolkClub(clubGod);
            //Console.WriteLine(clubGod.Name);
            //Console.WriteLine(clubGod.Age);
            //Console.WriteLine(clubGod.Budget);
            //Console.WriteLine(clubGod.DrinkableWhiskeys);
            //Console.WriteLine(clubGod.DrinkableVodkas);
            //Console.WriteLine(clubGod.PreferredMusic);

            FolkClub folkClub = new FolkClub("33", 35, 30, 70, "Azis");
            RockClub rockClub = new RockClub("RockIT", 20, 15, 110);
            HouseClub houseClub = new HouseClub("HousePlace", 45, 10, 110, 3);
            ListsOfClubs listOfClubs = new ListsOfClubs();

            listOfClubs.AddClubToTheList(folkClub);
            listOfClubs.AddClubToTheList(rockClub);
            listOfClubs.AddClubToTheList(houseClub);

            Console.WriteLine(folkClub.CanUserEnterTheClub(clubGod));

            //Console.WriteLine(listOfClubs.GetAllClubsName());
            //listOfClubs.GetAllClubsPrices();


            //RockClub rockClub = new RockClub("Rocket", 30, 25, 60);

            //Console.WriteLine(rockClub.capacity);
            //Console.WriteLine(rockClub.name);
            //Console.WriteLine(rockClub.priceOfWhiskey);
            //Console.WriteLine(rockClub.priceOfVodka);


        }


    }
}
