using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class User
    {
        private string name;
        private int age;
        private int budget;
        private int drinkableWhiskeys;
        private int drinkableVodkas;
        private string preferredMusic;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Budget
        {
            get
            {
                return budget;
            }

            set
            {
                budget = value;
            }
        }

        public int DrinkableWhiskeys
        {
            get
            {
                return drinkableWhiskeys;
            }

            set
            {
                drinkableWhiskeys = value;
            }
        }

        public int DrinkableVodkas
        {
            get
            {
                return drinkableVodkas;
            }

            set
            {
                drinkableVodkas = value;
            }
        }

        public string PreferredMusic
        {
            get
            {
                return preferredMusic;
            }

            set
            {
                preferredMusic = value;
            }
        }

        public User()
        {
            this.name = "";
            this.age = 0;
            this.budget = 0;
            this.drinkableWhiskeys = 0;
            this.drinkableVodkas = 0;
            this.preferredMusic = "";
        }

        public User(string name, int age, int budget, int drinkableWhiskeys, int drinkableVodkas, string preferredMusic)
        {
            this.name = name;
            this.age = age;
            this.budget = budget;
            this.drinkableWhiskeys = drinkableWhiskeys;
            this.drinkableVodkas = drinkableVodkas;
            this.preferredMusic = preferredMusic;
        }

       
    }
}
