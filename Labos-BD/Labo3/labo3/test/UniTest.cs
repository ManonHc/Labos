using labo3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1, context.Customers.ToList().Count);
            }
        }
        [TestInitialize]
        public void Setup()
        {
            Database.SetInitializer(new DBInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }

             public CompanyContext GetContext()
            {
                return new CompanyContext();
            }
        }
    }

