using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPDManagementSystem.Models;
using System;

namespace PatientHistoryTest
{
    [TestClass]
    public class UnitTestPatientHistory
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true); 
            p.AddPatientTransaction(new DateTime(2010, 12, 1, 10, 25, 56), jaundise);




            Assert.AreEqual(p, p); 
        }
    }
}
