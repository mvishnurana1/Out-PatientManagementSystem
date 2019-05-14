using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPDManagementSystem.Models;
using System;

namespace PatientHistoryTest
{
    [TestClass]
    public class UnitTestPatientHistory
    {
        [TestMethod]
        public void TestForNumberOfTransaction()
        {
            //Arrange 
            var patient = new Patient(4532, "James", "Smith"); 
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual(1, p.NumberOfTransactions()); 
        }

        [TestMethod]
        public void TestForTransactionsDetail()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual("True", 
               p.CheckTransactionLog(patient, new DateTime(2014, 12, 26), jaundise)); 
        }

        [TestMethod]
        public void TestForTransactionsDetailForDateNotMatchDate()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual("False",
               p.CheckTransactionLog(patient, new DateTime(2042, 09, 21), jaundise));
        }

        [TestMethod]
        public void TestForTransactionsDetailForDiseaseNotMatchDate()
        {
            //Arrange
            var patient = new Patient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            var yellowFever = new Disease("YellowFever", true); 
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual("False",
               p.CheckTransactionLog(patient, new DateTime(2042, 09, 21), yellowFever));
        }
    }
}
