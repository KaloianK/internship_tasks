using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{

    public class RockClub : Club
    {
        private const int MAX_CAPACITY_RockClub = 30;

       
        public RockClub(string name, int priceOfWhiskey, int priceOfVodka, int capacity) : base(name, priceOfWhiskey, priceOfVodka, capacity)
        {
            this.MusicPlayed = "Rock";
        }

        public override bool CanUserEnterTheClub(User user)
        {
            if (user.Age < 18)
            {
                user.Budget -= 20;
            }

            if (user.PreferredMusic == "Rock")
            {
                return false;
            }

            if (Capacity >= MAX_CAPACITY_RockClub)
            {
                return false;
            }

            base.CanUserEnterTheClub(user);

            return true;
        }

    }
}
