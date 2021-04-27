using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public abstract class Club
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string MusicPlayed { get; set; }
        public int whiskeyPrice;
        public int vodkaPrice;
        private List<User> listOfUsers = new List<User>();

        public Club(string name, int whiskeyPrice, int vodkaPrice, int capacity)
        {
            this.Name = name;
            this.WhiskeyPrice = whiskeyPrice;
            this.VodkaPrice = vodkaPrice;
            this.Capacity = capacity;
        }

        public List<User> ListOfUsers
        {
            get => this.listOfUsers;
            set => this.listOfUsers = value;
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

        public virtual bool CanUserEnter(User user)
        {
            decimal priceOfAlcohol = CostOfAlcoholToDrink(user.WhiskeysToDrink, user.VodkasToDrink);

            if (user.Budget < priceOfAlcohol)
            {
                return false;
            }
            else if (this.ListOfUsers.Count >= this.Capacity)
            {
                return false;
            }
            else if (!(user.PreferredMusic == Constants.MUSIC_EVERYTHING || this.MusicPlayed == user.PreferredMusic))
            {
                return false;
            }

            return true;
        }

        public decimal CostOfAlcoholToDrink(int whiskeysToDrink, int vodkasToDrink)
        {
            decimal convertedWhiskeyPrice = 0;
            decimal convertedVodkaPrice = 0;

            convertedWhiskeyPrice = this.WhiskeyPrice * whiskeysToDrink;
            convertedVodkaPrice = this.VodkaPrice * vodkasToDrink;

            return convertedVodkaPrice + convertedWhiskeyPrice;
        }

        public List<User> AddUserToClub(User user)
        {
            if (CanUserEnter(user))
            {
                this.ListOfUsers.Add(user);
            }

            return this.ListOfUsers;
        }

        public List<User> RemoveFromClub(User user)
        {
            this.ListOfUsers.Remove(user);
            return this.ListOfUsers;
        }

        public void PrintUserNamesInClubs()
        {
            StringBuilder userNamesInClubs = new StringBuilder();
            string[] userNamesArr = new string[listOfUsers.Count];
            userNamesInClubs.Append(this.Name + ": ");

            for (int i = 0; i < this.ListOfUsers.Count; i++)
            {
                userNamesArr[i] = this.ListOfUsers[i].Name;
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
