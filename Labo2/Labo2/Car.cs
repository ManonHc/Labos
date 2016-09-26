using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class Car
    {
       public String LicensePlate { get; set; }

        public Car (String plaque)
        {
            LicensePlate = plaque;
        }

        public override string ToString()
        {
            return "\nNuméro de plaque: "+ LicensePlate;
        }
    }
}
