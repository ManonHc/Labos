using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
   public class ProfessionalContact : Person
    {
        List<Entreprise> enterprises;

        public String Job { get; set; }
        public int TelPro { get; set; }
        public String MailPro { get; set; }

        public List<Entreprise> Enterprises {
             get
            {return enterprises; }
             set
            { enterprises = value;}
        }

        public ProfessionalContact(String name, String lastName, String job, int tel, String mail) : base(name, lastName)
        {
            TelPro = tel;
            MailPro = mail;
            Job = job;
            enterprises = new List<Entreprise>();
        }

        public override String ToString() {
            return base.ToString() + " (" + TelPro + ") \n" + MailPro + ((this.HasHisBirthday()) ? "\nBon anniversaire !" : " ");
        }

        public override Boolean HasHisBirthday() { return false; }

        public void EnterpriseAdd(Entreprise e)
        {
            enterprises.Add(e);
        }

        public String Print()
        {
            return base.ToString() + " est un contact professionnel";
        }
    }
}
