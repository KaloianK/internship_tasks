using System;
using System.Collections.Generic;
using System.Text;


namespace DrinkBook
{
    public class FolkClub : Club
    {
        private string singer;

        public FolkClub(string name, int priceOfWhiskey, int priceOfVodka, int capacity, string singer) : base(name, priceOfWhiskey, priceOfVodka, capacity)
        {
            this.MusicPlayed = Constants.MUSIC_FOLK;
            this.singer = singer;
        }

        public override bool CanUserEnterTheClub(User user)
        {
            if (user.Age < 18)
            {
                user.Budget -= 20;
            }

            if (user.PreferredMusic == Constants.MUSIC_FOLK || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_FolkClub)
            {
                return false;
            }



            if (base.CanUserEnterTheClub(user) == false)
            {
                return false;
            }
            else return true;
        }
    }
}
