using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public Contact (string l, string f, string e)
        {
            LastName = l;
            FirstName = f;
            Email = e;
        }
    }
}
