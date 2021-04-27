using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class RockClub : Club
    {
        public RockClub(string name, int whiskeyPrice, int vodkaPrice, int capacity) : base(name, whiskeyPrice, vodkaPrice, capacity)
        {
            this.MusicPlayed = Constants.MUSIC_ROCK;
        }

        public override bool CanUserEnter(User user)
        {
            if (user.Age < 18 || user.PreferredMusic == Constants.MUSIC_HOUSE || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_ROCKCLUB)
            {
                return false;
            }

            return base.CanUserEnter(user);            
        }
    }
}
