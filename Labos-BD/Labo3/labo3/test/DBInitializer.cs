using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labo3;

namespace test 
{
    public class DBInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                Name = "Manon Libert",
                AddressLine1 = "Rue de forêt 47",
                City = "Namur",
                EMail = "manon@wallontours.be",
                Id = 2,
                Remark = "Apporter des fleurs",
                PostCode = "5000"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
