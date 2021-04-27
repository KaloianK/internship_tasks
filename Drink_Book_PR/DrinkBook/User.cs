using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public class User
    {
       public string Name { get; set; }
        public int Age { get; set; }
        public int Budget { get; set; }
        public int WhiskeysToDrink { get; set; }
        public int VodkasToDrink { get; set; }
        public string PreferredMusic { get; set; }

        public User(string name, int age, int budget, int whiskeysToDrink, int vodkasToDrink, string preferredMusic)
        {
            this.Name = name;
            this.Age = age;
            this.Budget = budget;
            this.WhiskeysToDrink = whiskeysToDrink;
            this.VodkasToDrink = vodkasToDrink;
            this.PreferredMusic = preferredMusic;
        }
    }
}
