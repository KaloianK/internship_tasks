using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public interface Reproducible<T> where T : Cats
    {
        T[] Reproduce(T mate);
    }
}
