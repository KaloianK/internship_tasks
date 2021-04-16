using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   public abstract class Cats
    {
        private bool male;

        public Cats() //:this(true)  Are these equal ?
        {
            this.male = true;
        }

        public Cats(bool male)
        {
            this.male = male;
        }

        public bool Male
        {
            get
            {
                return male;
            }

            set
            {
                this.male = value;
            }
        }

        public abstract void CatchPrey(object pray);
    }
}
