using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Dog
    {
        private string name;

        public Dog(string Name)
        {
            this.name = Name;
        }

        public void Bark()
        {
            Console.WriteLine("Woof - Woof");
        }
        
        public void PrintInfo()
        {
            Console.WriteLine("Name of Dog in the shelter is: {0}!", this.name);
            this.Bark();
        }
    
    }


    class AnimalShelter
    {
        private const int DefaultPlacesCount = 20;
        private Dog[] animalList;
        private int usedPlaces;

        public AnimalShelter() : this(DefaultPlacesCount)
        {


        }

        public AnimalShelter(int placesCount)
        {
            this.animalList = new Dog[placesCount];
            this.usedPlaces = 0;
        }

        public void Shelter(Dog newAnimal)
        {
            if (this.usedPlaces >= this.animalList.Length)
            {
                    throw new InvalidOperationException("Shelter is full!");
            }

            this.animalList[this.usedPlaces] = newAnimal;
            this.usedPlaces++;
        }

        public Dog Release(int index)
        {
            if (index < 0 || index >= this.usedPlaces)
            {
                throw new ArgumentOutOfRangeException("Invalid cell index: " + index);
            }

            Dog releasedAnimal = this.animalList[index];

            for (int i = index; i < this.usedPlaces - 1; i++)
            {
                this.animalList[i] = this.animalList[i + 1];
            }
            this.animalList[this.usedPlaces - 1] = null;
            this.usedPlaces--;

            return releasedAnimal;
        }

        //public static void Main()
        //{

        //    AnimalShelter dogsShelter = new AnimalShelter(DefaultPlacesCount);
        //    Dog dog1 = new Dog("Boban");
        //    Dog dog2 = new Dog("Sharo");
        //    Dog dog3 = new Dog("Bolt");
           
           
        //    dogsShelter.Shelter(dog1);
        //    dogsShelter.Shelter(dog2);
        //    dogsShelter.Shelter(dog3);
           
            
        //    dogsShelter.Release(1); // Releasing dog2
          

        //    dog1.PrintInfo();
        //    dog2.PrintInfo();
        //    dog3.PrintInfo();
           
            

        //}

    }
}


