using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class ContactCar
    {
        public Person Person { get; set; }
        public Car Car { get; set; }

        public ContactCar(Person p, Car c)
        {
            Car = c;
            Person = p;
        }

        public void DynamicPrint(dynamic objet)
        {
            System.Console.Write(objet.Print() + "\nvoiture: " + Car);
        }
    }
}
