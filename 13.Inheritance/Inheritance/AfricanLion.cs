using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public class AfricanLion : Lion
    {
        public AfricanLion(bool male, int weight) : base(male,weight)
        {

        }

        public override string ToString()
        {
            return string.Format("AfricanLion, male: {0}, weight: {1}", this.Male, this.Weight);     
        }

        public override void CatchPrey(object pray)
        {
            Console.WriteLine("AfricanLion.CatchPray");
            Console.WriteLine("calling base.CatchPray");
            Console.Write("\t");
            base.CatchPrey(pray);
            Console.WriteLine("...end of call.");
        }
    }
}
