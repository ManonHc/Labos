using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Person
    {
        //private String name;
        private int age;

        //obtenu via Edit ; Refactor  ; Encapsulate Field
        //seulement si on veut une vérification du nom
        /*public string Name{
            get { return name;}

            set{ name = value;}
        }*/

        //raccourci si pas envie de mettre de vérification du nom
        //avec cette version on doit virer la declaration de la variable que j'ai du coup mis en comm au dssu
        public String Name { get; set; }
        public int Age
        {
            get { return age; }
            set { age = (value > 0) ? value : 1; }
        }

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " agé(e) de " + Age + " ans";
        }


    }
}
