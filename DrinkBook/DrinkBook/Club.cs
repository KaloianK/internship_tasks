using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkBook
{
    public abstract class Club
    {
        private string name;
        private int priceOfWhiskey;
        private int priceOfVodka;
        private int capacity;
        private int countOfPeople = 0;
        private string musicPlayed;
        
        private const int MAX_CAPACITY_HouseClub = int.MaxValue;
        private const int MAX_CAPACITY_RockClub = 30;

        public string MusicPlayed
        {
            get
            {
                return musicPlayed;
            }
            set
            {
                musicPlayed = value;
            }
        }

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

        public int PriceOfWhiskey
        {
            get
            {
                return priceOfWhiskey;
            }
            set
            {
                priceOfWhiskey = value;
            }
        }

        public int PriceOfVodka
        {
            get
            {
                return priceOfVodka;
            }
            set
            {
                priceOfVodka = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public Club()
        {
            this.name = "";
            this.priceOfWhiskey = 0;
            this.priceOfVodka = 0;
            this.capacity = 0;

        }

        public Club(string name, int priceOfWhiskey, int priceOfVodka, int capacity)
        {
            this.name = name;
            this.priceOfWhiskey = priceOfWhiskey;
            this.priceOfVodka = priceOfVodka;
            this.capacity = capacity;
        }

        public virtual bool CanUserEnterTheClub(User user)
        {
            int priceOfAlcohol = ConvertDrinkableAlcoholToMoney(user.DrinkableWhiskeys, user.DrinkableVodkas);
            

            if (user.Budget < priceOfAlcohol)
            {
                return false;
            }
            else if (this.capacity == this.countOfPeople)
            {
                return false;
            }
            else if (user.PreferredMusic != "Everything" || this.musicPlayed != user.PreferredMusic )
            {
                return false;
            }
            countOfPeople++;
            return true;
        }


        //FolkClub folkClub = new FolkClub();

        //HouseClub houseClub = new HouseClub();

        //RockClub rockClub = new RockClub("Rockarolla", 40, 20, 100);

        public int ConvertDrinkableAlcoholToMoney(int drinkableWhiskeys, int drinkableVodkas)
        {
            int fullPriceForAlcohol = 0;
            int currentPriceOfWhiskey = 0;
            int currentPriceOfVodka = 0;


            currentPriceOfWhiskey = this.PriceOfWhiskey * drinkableWhiskeys;
            currentPriceOfVodka = this.PriceOfVodka * drinkableVodkas;

            fullPriceForAlcohol = currentPriceOfVodka + currentPriceOfWhiskey;

            return fullPriceForAlcohol;
        }





    }


}
