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
        private int indice;
        private Dictionary<String, char> pupilActivities; 
        



        // propriété
    //    public List<Activity> ListActivities { get; set; }
   //     public char[] pupilEvaluation { get; set; }

        public int Grade
        {
            get
            { return grade; }
            set
            { grade = (value > 0 && value < 7) ? value : 1; }
        }

        public int Indice
        {
            get
            {return indice; }
            set
            {indice = 0;}
        }

        public Dictionary<string, char> PupilActivities  { get; set; }

        //constructeur
        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            pupilActivities = new Dictionary<string, char>();
            //ListActivities = new List<Activity>();
            //pupilEvaluation = new char[Parameter.NbActivity];
        }

        public Pupil(string name, int age) : this(name, age, 1) { }

        // méthode

        public void AddActivity(Activity activity)
        {
            PupilActivities.Add(activity.Title, 'O');
        }


        public override string ToString()
        {
            string chaine = HeaderPupil();
            return printActivities(chaine);
        }

        
        private string printActivities(string chaine)
        {
            if (pupilActivities.Count() == 0) { chaine += " n'a pas encore choisi"; return chaine; }
            else
            {
                chaine += "a choisi les activités suivantes : \n";
               /* foreach (Activity activity in pupilActivities)
                {
                    chaine += activity.ToString() + "\n";
                }*/
                return chaine;
            }
        }

        private string HeaderPupil() { return base.ToString();}

        public void AddEvaluation(String title = null, Parameter.Eval eval = Parameter.Eval.S)
        {
            pupilActivities[title] = (char)eval;
            this.indice++;
        }

       
    }
}


