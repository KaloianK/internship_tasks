using System;
using System.Collections.Generic;
using System.Text;


namespace DrinkBook
{
    public class FolkClub : Club
    {
        private string singer;
        private const int MAX_CAPACITY_FolkClub = 70;



        public FolkClub(string name, int priceOfWhiskey, int priceOfVodka, int capacity, string singer) : base(name, priceOfWhiskey, priceOfVodka, capacity)
        {
            this.singer = singer;
            this.MusicPlayed = "Folk";
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

            if (Capacity >= MAX_CAPACITY_FolkClub)
            {
                return false;
            }

            base.CanUserEnterTheClub(user);

           
            return true;
            
        }
        //public bool AddUserToFolkClub( clubGod)
        //{
        //    if )
        //}
    }
}
