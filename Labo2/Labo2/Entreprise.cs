using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
   public  class Entreprise
    {
        public String Location  { get; set; }
        public String Name { get; set; }


        public Entreprise (String loc, String name)
        {
            Name = name;
            Location = Location;
        }



        public override string ToString()
        {
            return Name + " located in " + Location;
        }
    }
}
