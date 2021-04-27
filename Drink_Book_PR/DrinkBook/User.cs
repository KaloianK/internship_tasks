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
        private int whiskeysToDrink;
        private int vodkasToDrink;
        private string preferredMusic;

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public int Budget
        {
            get => this.budget;
            set => this.budget = value;
        }

        public int WhiskeysToDrink
        {
            get => this.whiskeysToDrink; set => this.whiskeysToDrink = value;
        }

        public int VodkasToDrink
        {
            get => this.vodkasToDrink;
            set => this.vodkasToDrink = value;
        }

        public string PreferredMusic
        {
            get => this.preferredMusic;
            set => this.preferredMusic = value;
        }

        public User()
        {
            this.Name = "";
            this.Age = 0;
            this.Budget = 0;
            this.WhiskeysToDrink = 0;
            this.VodkasToDrink = 0;
            this.PreferredMusic = "";
        }

        public User(string name, int age, int budget, int drinkableWhiskeys, int drinkableVodkas, string preferredMusic)
        {
            this.Name = name;
            this.Age = age;
            this.Budget = budget;
            this.WhiskeysToDrink = drinkableWhiskeys;
            this.VodkasToDrink = drinkableVodkas;
            this.PreferredMusic = preferredMusic;
        }


    }
}
