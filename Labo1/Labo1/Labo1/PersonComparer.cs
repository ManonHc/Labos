using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public Boolean Equals(Person a, Person b)
        {
            Boolean egal = false;

            if (a.Age == b.Age && a.Name.Equals(b.Name))
            {
                egal = true;
            }
            return egal;

        }

        public int GetHashCode (Person a)
        {
            /*int hash = a.Name ^ a.Age;
            return hash;*/
        }
    }
}
