using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class HouseClub : Club
    {
        private int numberOfDJs;

        public int NumberOfDJs
        {
            get => this.numberOfDJs;
            set => this.numberOfDJs = value;
        }

        public HouseClub(string name, int whiskeyPrice, int vodkaPrice, int capacity, int numberOfDjs) : base(name, whiskeyPrice, vodkaPrice, capacity)
        {
            this.NumberOfDJs = numberOfDjs;
            this.MusicPlayed = Constants.MUSIC_HOUSE;
        }

        public override bool CanUserEnter(User user)
        {
            if (user.Age < 18 || user.PreferredMusic == Constants.MUSIC_HOUSE || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_HOUSECLUB)
            {
                return false;
            }

            return base.CanUserEnter(user);
        }
    }
}
