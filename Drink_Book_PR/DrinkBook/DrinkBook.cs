using System;

namespace DrinkBook
{
    public class DrinkBook
    {
       public static void Main(string[] args)
        {         
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

            listOfClubs.AddClub(folkClub);
            listOfClubs.AddClub(rockClub);
            listOfClubs.AddClub(houseClub);

            folkClub.CanUserEnter(clubGod); 
            folkClub.CanUserEnter(folkGod); 
            houseClub.CanUserEnter(everythingGod); 
            rockClub.CanUserEnter(rockGod); 
            folkClub.CanUserEnter(folkUser);
            folkClub.CanUserEnter(userStefan);
            folkClub.CanUserEnter(userDani);
            houseClub.CanUserEnter(userDamon);
            rockClub.CanUserEnter(userMaria);


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

            folkClub.RemoveFromClub(clubGod);
            folkClub.RemoveFromClub(folkGod);
            houseClub.RemoveFromClub(everythingGod);
            rockClub.RemoveFromClub(rockGod);
            folkClub.RemoveFromClub(folkUser);
            folkClub.RemoveFromClub(userStefan);
            folkClub.RemoveFromClub(userDani);
            houseClub.RemoveFromClub(userDamon);
            rockClub.RemoveFromClub(userMaria);

            Console.WriteLine("User names after removal: (should be blank)");
            folkClub.PrintUserNamesInClubs();
            houseClub.PrintUserNamesInClubs();
            rockClub.PrintUserNamesInClubs();
        }
    }
}
