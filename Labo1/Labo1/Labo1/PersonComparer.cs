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
        public Boolean Equals (Person a, Person b)
        {
            return ((a.Name.Equals(b.Name) && (a.Age == b.Age)));
        }

        // en gros ces deux fonction s'utilisent l'un eet l'autre mais ne sont pas appelée par nous
        // elles seront utilisée quand dans program.cs on va appeler list.Distinct
        public int GetHashCode (Person a)
        {
            return (a.Name.GetHashCode()) ^ (a.Age);
        }
    }
}
