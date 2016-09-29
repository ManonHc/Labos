using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Activity
    {

        // attributs
        private string title;

        //propriété
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Boolean Compulsory { get; set; }


        //constructuer

        public Activity(String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }

        // méthode


        public override string ToString()
        {
            String ch = Title;
            if (Compulsory)
            {
                ch += " (obligatoire)";
            }
            ch += "\n";
            return ch;
        }
    }
}
