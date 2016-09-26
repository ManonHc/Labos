using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class ProfessionalContact : Person
    {

        public String Job { get; set; }
        public int TelPro { get; set; }
        public String MailPro { get; set; }

        public ProfessionalContact(String name, String lastName, String job, int tel, String mail) : base(name, lastName)
        {
            TelPro = tel;
            MailPro = mail;
            Job = job;
        }

        public override String ToString()
        {
            return base.ToString() + " (" + TelPro + ") \n" + MailPro + ((this.HasHisBirthday()) ? "\nBon anniversaire !" : " ");
        }

        public override Boolean HasHisBirthday()
        {
            return false;
        }
    }
}
