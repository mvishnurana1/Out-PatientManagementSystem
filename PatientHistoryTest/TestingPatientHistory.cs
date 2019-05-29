using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPDManagementSystem.Models;
using System;

namespace PatientHistoryTest
{
    [TestClass]
    public class UnitTestPatientHistory
    {
        [TestMethod]
        public void TestNumberOfTransaction()
        {
            //Arrange 
            var patient = new NationalPatient(4532, "James", "Smith"); 
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.AreEqual(1, p.NumberOfTransactions()); 
        }

        [TestMethod]
        public void TestTransactionsDate()
        {
            //Arrange
            var patient = new InternationalPatient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsTrue(p.CheckTransactionLogAvailability(patient, new DateTime(2014, 12, 26))); 
        }

        [TestMethod]
        public void TestTransactionsDetailForDateNotMatchDate()
        {
            //Arrange
            var patient = new NationalPatient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsFalse(p.CheckTransactionLogAvailability(patient, new DateTime(2042, 09, 21)));
        }

        [TestMethod]
        public void TestTransactionsDetailForDiseaseNotMatchDate()
        {
            //Arrange
            var patient = new InternationalPatient(4532, "James", "Smith");
            var p = new PatientHistory();
            var jaundise = new Disease("Jaundice", true);

            //Act
            var yellowFever = new Disease("YellowFever", true); 
            p.AddPatientTransaction(patient, new DateTime(2014, 12, 26), jaundise);

            //Assert
            Assert.IsFalse(p.CheckTransactionLogAvailability(patient, new DateTime(2042, 09, 21)));
        }

        [TestMethod]
        public void TestTransactionDiseaseLog()
        {
            //Arrange 
            var patient = new NationalPatient(4532, "James", "Smith");
            var p = new PatientHistory();
            var cancer = new Disease("Cancer", true);

            // Act 
            p.AddPatientTransaction(patient, new DateTime(2015, 12, 26), cancer); 

            //Assert
            Assert.AreEqual("Cancer", p.ReturnDiseaseLog(patient, new DateTime(2015, 12, 26))); 
        }

        [TestMethod]
        public void TestPatientID_Detail()
        {
            // Arrange
            var patient = new InternationalPatient(25495, "James", "Smith");
            var aids = new Disease("AIDS", false);
            var history = new PatientHistory();
            var date = new DateTime(2015, 11, 26);

            // Act 
            history.AddPatientTransaction(patient, date, aids);

            // Assert 
            Assert.AreEqual(25495, history.ReturnPatientDetails(date, aids).PatientID); 
        }
    }
}
