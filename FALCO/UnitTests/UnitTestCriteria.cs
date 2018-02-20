using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Data.Entity;

namespace UnitTests
{
    [TestClass]
    public class UnitTestCriteria
    {
        [TestMethod]
        public void TestMethod1()
        {

            using (ApplicationContext _context = new ApplicationContext())
            {
               // Criteria c = new Criteria();
               // c.Title = "Criteria";
               // _context.Criterias.Add(c);
               // _context.SaveChanges();
                Assert.IsTrue(_context.Database.Exists());
                //Assert.AreEqual(c.Title, _context.Criterias.Find(c.Id).Title);
                
                //_context.Criterias.Remove(_context.Criterias.Find(c.Id));
                //_context.SaveChanges();
                //Assert.IsNull(_context.Criterias.Find(c.Id));
            } 
        }
    }
}
