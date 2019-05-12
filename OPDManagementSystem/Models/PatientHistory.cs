using System;
using System.Collections.Generic;

namespace OPDManagementSystem.Models
{
    public class PatientHistory
    {
        private IDictionary<Patient, Disease> contactInstance = new Dictionary<Patient, Disease>();

        /// <summary>
        /// The method takes add the patient transaction 
        /// with the hospital to add a log to the history. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="disease"></param>
        public void AddPatientTransaction(Patient patient, Disease disease)
        {
            contactInstance.Add(patient, disease);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="disease"></param>
        public void RemovePatientTransaction(Patient patient)
        {
            contactInstance.Remove(patient);
        }

        /// <summary>
        /// Method prints all the patient transactions with 
        /// OPD on the console. 
        /// </summary>
        public void GetAllPatientTransactions()
        {
            foreach (KeyValuePair<Patient, Disease> item in contactInstance)
            {
                Console.WriteLine("Key: {0} {1} {2} Value: {3}", item.Key.PatientID, item.Key.FirstName, 
                    item.Key.LastName, item.Value.MedicalIssue);
            }
        }

        public int NumberOfTransactions()
        {
            return contactInstance.Count; 
        }
    }
}
