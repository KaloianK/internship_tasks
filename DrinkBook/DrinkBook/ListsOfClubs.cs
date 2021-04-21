using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class ListsOfClubs
    {
        private const int startingSize = 4;


        List<Club> listOfClubs = new List<Club>();


        public ListsOfClubs()
        {

        }

        public void AddClubToTheList(Club club)
        {
            this.listOfClubs.Add(club);
        }

        public string GetAllClubsName()
        {
            StringBuilder clubNames = new StringBuilder();

            for (int i = 0; i < this.listOfClubs.Count; i++)
            {
                clubNames.Append(this.listOfClubs[i].Name + ", ");
            }

            return clubNames.ToString();
        }

        public void GetAllClubsPrices()
        {
            for (int i = 0; i < this.listOfClubs.Count; i++)
            {
                Console.WriteLine("In {0} the price of whiskey is: {1} lv.", this.listOfClubs[i].Name, this.listOfClubs[i].PriceOfWhiskey);
                Console.WriteLine("In {0} the price of vodka is: {1} lv.", this.listOfClubs[i].Name, this.listOfClubs[i].PriceOfVodka);

            }
        }

        public int GetClubIndexByName(string clubName)
        {

            for (int i = 0; i < this.listOfClubs.Count; i++)
            {
                if (listOfClubs[i].Name == clubName)
                {
                    return i;
                }
            }

            return -1;
        }


        public bool AddUserToClub(User user, string clubName)
        {
            bool canWeAddTheUserInTheClub = false;

            int indexOfClub = GetClubIndexByName(clubName);
            if (indexOfClub >= 0)
            {
                Club club = this.listOfClubs[indexOfClub];
                
                bool canUserEnter = club.CanUserEnterTheClub(user);
            }
                //  listOfClubs.IndexOf()
                //{
                //1. Check if user's age is above 18. If false budget -=20 return canWeAddTheClubGodInTheFolkClub else check if capacity > maxCapacity ->
                //-> if true throw exception"THe club's limit is full you cant enter" return canWeAddTheClubGodInTheFolkClub-->
                //-->else Check if user's budget is lower than PriceOfWhiskey + PriceOfVodka.--->
                //--->If true throw exception "Your budget is not enought to drink this many drinks! Try less drinks or higher budget!"---->
                //----> else return canWeAddTheClubGodInTheFolkClub = true;
                // }
                // 
                return canWeAddTheUserInTheClub;



        }
    }
}
