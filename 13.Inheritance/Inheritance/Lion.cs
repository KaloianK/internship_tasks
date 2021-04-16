using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Lion : Cats, Reproducible<Lion>
    {
        private int weight;

        public Lion(bool male, int weight) : base(male)
        {
            //base.male = male;  // not visible due to irs protection level!
            this.weight = weight;
        }

        Lion[] Reproducible<Lion>.Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12), new Lion(false, 10) };
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                this.weight = value;
            }
        }
        public override void CatchPrey(object pray)
        {
            Console.WriteLine("Lion.CatchPrey");
        }
    }
}
