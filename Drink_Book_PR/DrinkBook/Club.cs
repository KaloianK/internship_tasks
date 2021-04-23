using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public abstract class Club
    {
        private string name;
        private int priceOfWhiskey;
        private int priceOfVodka;
        private int capacity;

        private string musicPlayed;

        List<User> listOfUsers = new List<User>();

        public string MusicPlayed
        {
            get
            {
                return musicPlayed;
            }
            set
            {
                musicPlayed = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int PriceOfWhiskey
        {
            get
            {
                return priceOfWhiskey;
            }
            set
            {
                priceOfWhiskey = value;
            }
        }

        public int PriceOfVodka
        {
            get
            {
                return priceOfVodka;
            }
            set
            {
                priceOfVodka = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public Club()
        {
            this.name = "";
            this.priceOfWhiskey = 0;
            this.priceOfVodka = 0;
            this.capacity = 0;

        }

        public Club(string name, int priceOfWhiskey, int priceOfVodka, int capacity)
        {
            this.name = name;
            this.priceOfWhiskey = priceOfWhiskey;
            this.priceOfVodka = priceOfVodka;
            this.capacity = capacity;
        }

        public virtual bool CanUserEnterTheClub(User user)
        {
            int priceOfAlcohol = ConvertDrinkableAlcoholToMoney(user.DrinkableWhiskeys, user.DrinkableVodkas);


            if (user.Budget < priceOfAlcohol)
            {
                return false;
            }
            else if (this.listOfUsers.Count >= this.capacity)
            {
                return false;
            }
            else if (!(user.PreferredMusic == Constants.MUSIC_EVERYTHING || this.musicPlayed == user.PreferredMusic))
            {
                return false;
            }

            return true;
        }

        public int ConvertDrinkableAlcoholToMoney(int drinkableWhiskeys, int drinkableVodkas)
        {
            int fullPriceForAlcohol = 0;
            int currentPriceOfWhiskey = 0;
            int currentPriceOfVodka = 0;

            currentPriceOfWhiskey = this.PriceOfWhiskey * drinkableWhiskeys;
            currentPriceOfVodka = this.PriceOfVodka * drinkableVodkas;

            fullPriceForAlcohol = currentPriceOfVodka + currentPriceOfWhiskey;

            return fullPriceForAlcohol;
        }

        public List<User> ListOfUsers
        {
            get
            {
                return listOfUsers;
            }
            set
            {
                listOfUsers = value;
            }
        }

        public List<User> AddUserToClub(User user)
        {
            if (CanUserEnterTheClub(user) == true)
            {
                listOfUsers.Add(user);
            }
            return listOfUsers;
        }

        public List<User> RemoveUserFromClub(User user)
        {
            listOfUsers.Remove(user);
            return listOfUsers;
        }

        public void PrintUserNamesInClubs()
        {
            StringBuilder userNamesInClubs = new StringBuilder();
            string[] userNamesArr = new string[listOfUsers.Count];
            userNamesInClubs.Append(this.name + ": ");

            for (int i = 0; i < this.listOfUsers.Count; i++)
            {
                userNamesArr[i] = this.listOfUsers[i].Name;
            }

            if (listOfUsers.Count == 0)
            {
                userNamesInClubs.Append("The Club is empty");
            }
            else
            {
                userNamesInClubs.AppendJoin(".|.", userNamesArr);
            }

            Console.WriteLine(userNamesInClubs);

        }



    }


}
