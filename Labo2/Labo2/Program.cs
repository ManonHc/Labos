using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
   public  class Program
    {
        static void Main(string[] args)
        {
            PrivateContact manon = new PrivateContact("Manon", "Libert", "manon@gmail.com", 0471243525);
            PrivateContact leandro = new PrivateContact("Leandro", "Gaone", "Leandro@pb.be", 02727482, new DateTime(1986,09,26));

            Entreprise iesn = new Entreprise("Namur", "IESN");
            Entreprise proximus = new Entreprise("Bruxelles", "Proximus");

            

            ProfessionalContact john = new ProfessionalContact("Jonathan", "Giacomello", "consultant", 01847292, "john@gmail.com");
            john.EnterpriseAdd(iesn);
            john.EnterpriseAdd(proximus);
            ProfessionalContact olivier = new ProfessionalContact("Olivier", "Beguin", "independant", 0198424, "olivier@apple.be");
            olivier.EnterpriseAdd(iesn);
            ProfessionalContact antho = new ProfessionalContact("Anthony", "Maniscalco", "consultant",0987654," antho@sicilien.it");

            Car bmw = new Car("AVD-566");
            ContactCar contactCar = new ContactCar(antho, bmw);
            contactCar.DynamicPrint(antho);

            List<ProfessionalContact> contactPro = new List<ProfessionalContact>();
            contactPro.Add(john);
            contactPro.Add(olivier);
            contactPro.Add(antho);




            var contactProIndependant = from professionalContact in contactPro
                                        where professionalContact.Job.Equals("independant")
                                        select professionalContact;

            var contactProConsultant = contactPro.Where(consultant => consultant.Job.Equals("consultant"));
            System.Console.Write(contactProConsultant.Count());
            //contactProIndependant.Count();


            System.Console.Read();
            
        }
    }
}
