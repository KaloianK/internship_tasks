using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class ListsOfClubs
    {
        private const int startingSize = 4;

        public List<Club> listOfClubs = new List<Club>();

        public void AddClub(Club club)
        {
            this.listOfClubs.Add(club);
        }

        public string GetAllClubsName()
        {
            StringBuilder clubNames = new StringBuilder();

            for (int i = 0; i < this.listOfClubs.Count; i++)
            {
                clubNames.AppendJoin(',', this.listOfClubs[i].Name);
            }

            return clubNames.ToString();
        }

        public void AlcoholPrices()
        {
            for (int i = 0; i < this.listOfClubs.Count; i++)
            {
                Console.WriteLine("In {0} the price of whiskey is: {1} lv.", this.listOfClubs[i].Name, this.listOfClubs[i].WhiskeyPrice);
                Console.WriteLine("In {0} the price of vodka is: {1} lv.", this.listOfClubs[i].Name, this.listOfClubs[i].VodkaPrice);
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
    }
}
