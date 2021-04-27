using System;
using System.Collections.Generic;
using System.Text;


namespace DrinkBook
{
    public class FolkClub : Club
    {
        private string singer;

        public string Singer
        {
            get => this.singer;
            set => this.singer = value;
        }

        public FolkClub(string name, int whiskeyPrice, int vodkaPrice, int capacity, string singer) : base(name, whiskeyPrice, vodkaPrice, capacity)
        {
            this.MusicPlayed = Constants.MUSIC_FOLK;
            this.Singer = singer;
        }

        public override bool CanUserEnter(User user)
        {
            if (user.Age < 18)
            {
                user.Budget -= 20;
            }

            if (user.PreferredMusic == Constants.MUSIC_ROCK || this.ListOfUsers.Count >= Constants.MAX_CAPACITY_FOLKCLUB)
            {
                return false;
            }

            return base.CanUserEnter(user);          
        }
    }
}
