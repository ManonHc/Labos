using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Pupil : Person
    {
        //attributs
        private int grade;

        // propriété
        public List<Activity> ListActivities { get; set; }
        public char[] pupilEvaluation { get; set; }

        public int Grade
        {
            get
            { return grade; }
            set
            { grade = (value > 0 && value < 7) ? value : 1; }
        }

        //constructeur
        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            pupilEvaluation = new char[Parameter.NbActivity];
            
        }

        public Pupil(string name, int age) : this(name, age, 1) { }

        // méthode

        public void AddActivity(Activity activity)
        {
            ListActivities.Add(activity);
        }


        public override string ToString()
        {
            string chaine = base.ToString();
            if (ListActivities.Count() == 0) { chaine += " n'a pas encore choisi"; return chaine; }
            else
            {
                chaine += "a choisi les activités suivantes : \n";
                foreach (Activity activity in ListActivities)
                {
                    chaine += activity.ToString() + "\n";
                }
                return chaine;
            }
        }

        public void AddEvaluation(String title = null, Parameter.Eval eval = Parameter.Eval.S)
        {
            System.Console.Write(eval);
            pupilEvaluation[0] = (char)eval;
        }



    }
}


