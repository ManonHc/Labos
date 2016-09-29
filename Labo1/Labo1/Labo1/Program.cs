using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //********** déclarations************
            List<Pupil> listPupilDuplicated = new List<Pupil>() {

                new Pupil("Manon", 6, 1),
                new Pupil("Manon", 6, 1),
                new Pupil("Adrien", 7, 1),
                new Pupil("Adrien", 7, 2),
                new Pupil("Louis", 6, 1),
                new Pupil("Adrien", 7, 2),
                new Pupil("Marvin", 8, 1),
        };

            IEnumerable<Pupil> listPupilsNotDuplicated = listPupilDuplicated.Distinct<Pupil>(new PersonComparer());



            Pupil manon = new Pupil("manon", 6, 1);
            List<Pupil> listPupil = new List<Pupil>() {

                new Pupil("Manon", 6, 1),
                new Pupil("Nicolas", 9, 1),
                new Pupil("Adrien", 7, 1),
                new Pupil("Jennifer", 6, 2),
                new Pupil("Louis", 6, 1),
                new Pupil("Vale", 7, 2),
                new Pupil("Marvin", 8, 1),
        };

         
            List<Person> listPerson = new List<Person>() {

                new Person("Manon", 6),
                new Person("Nicolas", 9),
                new Person("Adrien", 7),
                new Person("Jennifer", 6),
                new Person("Louis", 6),
                new Person("Vale", 7),
                new Person("Marvin", 8),
        };
                // union via le principe de covariance
            var listFusion = listPerson.Union(listPupil);

            Activity piscine = new Activity("piscine", true);
            Activity yoga = new Activity("Yoga", true);
            Activity judo = new Activity("Judo", false);
            Activity coloriage = new Activity("Coloriage", true);
            Activity gym = new Activity("Gym", true);



            //******Utilisation méthodes ***********
            manon.AddActivity(piscine);
            manon.AddActivity(yoga);
            manon.AddActivity(judo);
            manon.AddActivity(gym);
            manon.AddActivity(coloriage);

            manon.AddEvaluation("Piscine", Parameter.Eval.R);
            manon.AddEvaluation("Judo", Parameter.Eval.R);
            manon.AddEvaluation("Coloriage", Parameter.Eval.R);

            /* ==> première version avec LINQ
            var pupilGradePlus6 = from pupil in listPupil
                                    where pupil.Age > 6 && pupil.Grade == 1
                                    select pupil;*/
            //notons ici que le select est en dernier... pq?
            
            
            
            // version expression lambda. on saura ici que pupil est un objet de la liste car la liste est de type pupil
            var pupilGradePlus6 = listPupil.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);


            //******** différents affichage *******
            if(pupilGradePlus6 != null)
                foreach(var pupil in pupilGradePlus6)
                {
                    pupil.AddActivity(yoga);
                    pupil.AddActivity(piscine);
                    pupil.AddActivity(coloriage);
                    System.Console.Write(pupil+"\n");
                }

            /*foreach (var person in listFusion)
            { 
                System.Console.Write(person + "\n");
            }*/
            //System.Console.Write(manon.pupilEvaluation[0]);
            
            System.Console.Read();
        }
    }
}
