using System;

namespace Inheritance
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            AfricanLion africanLion = new AfricanLion(true, 80);
            object obj = africanLion;

           // Console.WriteLine(obj);

           // Console.WriteLine(new object());

            //Console.WriteLine(new Cats(true));

            //Console.WriteLine(new Lion(true, 80));

            Lion lion = new Lion(true, 80);
            lion.CatchPrey(null);

            AfricanLion africanLion1 = new AfricanLion(true, 120);
            africanLion1.CatchPrey(null);

            Lion lion1 = new AfricanLion(false, 60);
            lion1.CatchPrey(null);

           
        }
    }
}
