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
        }
    }
}
