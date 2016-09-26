using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        
        public String LastName  { get; set; }
        public String Name { get; set; }
    
        public Person(string name, String lastName)
        {
            Name= name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return LastName + " " + Name;
        }

        public abstract Boolean HasHisBirthday();
        
    }
}
