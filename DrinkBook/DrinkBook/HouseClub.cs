using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class HouseClub : Club
    {
        private int numberOfDjs;

        public HouseClub(string name, int priceOfWHiskey, int priceOfVodka, int capacity, int numberOfDjs) : base(name, priceOfWHiskey, priceOfVodka, capacity)
        {
            this.numberOfDjs = numberOfDjs;
            this.MusicPlayed = Constants.MUSIC_HOUSE;
        }

        public override bool CanUserEnterTheClub(User user)
        {
            if (user.Age < 18 || user.PreferredMusic == Constants.MUSIC_HOUSE || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_HouseClub)
            {
                return false;
            }

            base.CanUserEnterTheClub(user);

            return true;

        }

    }
}
