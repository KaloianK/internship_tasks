using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{

    public class RockClub : Club
    {
        public RockClub(string name, int priceOfWhiskey, int priceOfVodka, int capacity) : base(name, priceOfWhiskey, priceOfVodka, capacity)
        {
            this.MusicPlayed = Constants.MUSIC_ROCK;
        }

        public override bool CanUserEnterTheClub(User user)
        {
            if (user.Age < 18 || user.PreferredMusic == Constants.MUSIC_ROCK || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_RockClub)
            {
                return false;
            }

            base.CanUserEnterTheClub(user);

            return true;
        }

    }
}
