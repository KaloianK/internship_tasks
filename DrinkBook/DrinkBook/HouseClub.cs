using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class HouseClub : Club
    {
        private int numberOfDjs;
        private const int MAX_CAPACITY_HouseClub = int.MaxValue;

     

        public HouseClub(string name, int priceOfWHiskey, int priceOfVodka, int capacity, int numberOfDjs) : base(name, priceOfWHiskey, priceOfVodka, capacity)
        {
            this.numberOfDjs = numberOfDjs;
            this.MusicPlayed = "House";
        }

        public override bool CanUserEnterTheClub(User user)
        {
            if (user.Age < 18)
            {
                return false;
            }

            if (user.PreferredMusic == "Folk")
            {
                return false;
            }

            if (Capacity >= MAX_CAPACITY_HouseClub)
            {
                return false;
            }

            base.CanUserEnterTheClub(user);

            return true;
            
        }

    }
}
