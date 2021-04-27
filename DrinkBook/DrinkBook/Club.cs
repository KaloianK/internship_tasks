using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public abstract class Club
    {
        private string name;
        private int whiskeyPrice;
        private int vodkaPrice;
        private int capacity;

        private string musicPlayed;

        private List<User> listOfUsers = new List<User>();

        public string MusicPlayed
        {
            get => this.musicPlayed;
            set => this.musicPlayed = value;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int WhiskeyPrice
        {
            get
            {
                return this.whiskeyPrice;
            }
            set
            {
                this.whiskeyPrice = value;

                if (this.whiskeyPrice <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price of whiskey can not be negative number or 0 !");
                }
            }
        }

        public int VodkaPrice
        {
            get
            {
                return this.vodkaPrice;
            }
            set
            {
                this.vodkaPrice = value;

                if (this.vodkaPrice <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price of vodka can not be negative number or 0 !");
                }
            }
        }

        public int Capacity
        {
            get => this.capacity;
            set => this.capacity = value;
        }

        public Club()
        {
            this.name = "";
            this.whiskeyPrice = 0;
            this.vodkaPrice = 0;
            this.capacity = 0;
        }

        public Club(string name, int whiskeyPrice, int vodkaPrice, int capacity)
        {
            this.Name = name;
            this.WhiskeyPrice = whiskeyPrice;
            this.VodkaPrice = vodkaPrice;
            this.Capacity = capacity;
        }

        public virtual bool CanUserEnter(User user)
        {
            int priceOfAlcohol = CostOfAlcoholToDrink(user.WhiskeysToDrink, user.VodkasToDrink);

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

        public int CostOfAlcoholToDrink(int whiskeysToDrink, int vodkasToDrink)
        {
            int costOfAlcohol = 0;
            int convertedWhiskeyPrice = 0;
            int convertedVodkaPrice = 0;

            convertedWhiskeyPrice = this.WhiskeyPrice * whiskeysToDrink;
            convertedVodkaPrice = this.VodkaPrice * vodkasToDrink;

            return costOfAlcohol = convertedVodkaPrice + convertedWhiskeyPrice;
        }

        public List<User> ListOfUsers
        {
            get => this.listOfUsers;
            set => this.listOfUsers = value;

        }

        public List<User> AddUserToClub(User user)
        {
            if (CanUserEnter(user))
            {
                this.listOfUsers.Add(user);
            }
            return this.listOfUsers;
        }

        public List<User> RemoveFromClub(User user)
        {
            this.listOfUsers.Remove(user);
            return this.listOfUsers;
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
