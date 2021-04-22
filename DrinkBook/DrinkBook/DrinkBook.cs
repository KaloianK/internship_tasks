using System;

namespace DrinkBook
{
    public class DrinkBook
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your name: ");
            //string inputName = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int inputAge = int.Parse(Console.ReadLine());
            //Console.Write("Enter your budget: ");
            //int inputBudget = int.Parse(Console.ReadLine());
            //Console.Write("Enter the amount of Whiskeys you want to drink: ");
            //int inputDrinkableWhiskeys = int.Parse(Console.ReadLine());
            //Console.Write("Enter the amount of Vodkas you want to drink: ");
            //int inputDrinakbleVodkas = int.Parse(Console.ReadLine());
            //Console.Write("Enter the music you prefer to listen (Folk, Rock, House, Everything): ");
            //string inputPreferredMusic = Console.ReadLine();

            User clubGod = new User("Boban", 25, 200, 2, 3, "Folk");
            User folkGod = new User("Georji", 24, 180, 3, 4, "House");
            User everythingGod = new User("Koki", 15, 250, 3, 1, "Everything");
            User rockGod = new User("Pepi", 30, 100, 3, 2, "Rock");
            User folkUser = new User("Maxim", 22, 230, 3, 4, "Folk");
            User userStefan = new User("Stefan", 26, 230, 2, 1, "Folk");
            User userDani = new User("Daniel", 17, 300, 4, 2, "Folk");
            User userDamon = new User("Damon", 20, 100, 1, 1, "Rock");
            User userMaria = new User("Maria", 28, 150, 2, 2, "Rock");

            FolkClub folkClub = new FolkClub("33", 35, 30, 2, "Azis");
            RockClub rockClub = new RockClub("RockIT", 20, 15, 3);
            HouseClub houseClub = new HouseClub("HousePlace", 45, 10, 110, 3);
            ListsOfClubs listOfClubs = new ListsOfClubs();

            listOfClubs.AddClubToTheList(folkClub);
            listOfClubs.AddClubToTheList(rockClub);
            listOfClubs.AddClubToTheList(houseClub);

            folkClub.CanUserEnterTheClub(clubGod); // true
            folkClub.CanUserEnterTheClub(folkGod); // false
            houseClub.CanUserEnterTheClub(everythingGod); // false
            rockClub.CanUserEnterTheClub(rockGod); // false
            folkClub.CanUserEnterTheClub(folkUser);//true
            folkClub.CanUserEnterTheClub(userStefan);//true
            folkClub.CanUserEnterTheClub(userDani);//true
            houseClub.CanUserEnterTheClub(userDamon);//true
            rockClub.CanUserEnterTheClub(userMaria);//false


            folkClub.AddUserToClub(clubGod);
            folkClub.AddUserToClub(folkGod);
            houseClub.AddUserToClub(everythingGod);
            rockClub.AddUserToClub(rockGod);
            folkClub.AddUserToClub(folkUser);
            folkClub.AddUserToClub(userStefan);
            folkClub.AddUserToClub(userDani);
            houseClub.AddUserToClub(userDamon);
            rockClub.AddUserToClub(userMaria);

            Console.WriteLine("User names before removing them: ");
            folkClub.PrintUserNamesInClubs();
            houseClub.PrintUserNamesInClubs();
            rockClub.PrintUserNamesInClubs();

            folkClub.RemoveUserFromClub(clubGod);
            folkClub.RemoveUserFromClub(folkGod);
            houseClub.RemoveUserFromClub(everythingGod);
            rockClub.RemoveUserFromClub(rockGod);
            folkClub.RemoveUserFromClub(folkUser);
            folkClub.RemoveUserFromClub(userStefan);
            folkClub.RemoveUserFromClub(userDani);
            houseClub.RemoveUserFromClub(userDamon);
            rockClub.RemoveUserFromClub(userMaria);

            Console.WriteLine("User names after removal: (should be blank)");
            folkClub.PrintUserNamesInClubs();
            houseClub.PrintUserNamesInClubs();
            rockClub.PrintUserNamesInClubs();
        }
    }
}
