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
            p.AddPatientTransaction(new Patient(45236), jaundise);

            Assert.AreEqual(p, p); 
        }
    }
}
