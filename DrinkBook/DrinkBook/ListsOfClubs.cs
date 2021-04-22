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

            return canWeAddTheUserInTheClub;
        }
    }
}
