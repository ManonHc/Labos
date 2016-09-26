using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class PrivateContact : Person
    {
       
        public String MailPrivé { get; set; }
        public int TelPrivé { get; set; }
        public DateTime DateNaiss { get; set; }

        public PrivateContact(String name, String lastName, String mail, int tel, DateTime dateNaiss) : base(name, lastName)
        {
            MailPrivé = mail;
            TelPrivé = tel;
            DateNaiss = dateNaiss;
        }

        public PrivateContact(String name, String lastName, String mail, int tel) : this(name, lastName, mail, tel, Convert.ToDateTime(null)){ }

        public override string ToString()
        {
            return base.ToString() + " (" + TelPrivé + ") \n" + MailPrivé +( (this.HasHisBirthday()) ? "\nBon anniversaire !" : " ");
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == DateNaiss.Month && DateTime.Today.Day == DateNaiss.Day);
            
        }
    }
}
