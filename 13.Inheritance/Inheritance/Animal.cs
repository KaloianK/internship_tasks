using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public abstract class Animal
    {
        public void PrintInformation()
        {
            Console.WriteLine("I am {0}!", this.GetType().Name);
            Console.WriteLine(GetTypicalSound());
        }

        protected abstract String GetTypicalSound();
    }
}
