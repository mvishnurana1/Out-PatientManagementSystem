using System;
using System.Collections.Generic;

namespace OPDManagementSystem.Models
{
    public class PatientHistory
    {
        private Dictionary<Tuple<Patient, DateTime>, Disease> contactInstance = 
            new Dictionary<Tuple<Patient, DateTime>, Disease>();  

        /// <summary>
        /// The method takes add the patient transaction 
        /// with the hospital to add a log to the history. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="disease"></param>
        public void AddPatientTransaction(Patient patient, DateTime time, Disease disease)
        {
            var key = Tuple.Create(patient, time); 
            contactInstance.Add(key, disease);
        }

        public void RemovePatientTransaction(Patient patient, DateTime time)
        {
            var key = Tuple.Create(patient, time); 
            contactInstance.Remove(key);
        }

        /// <summary>
        /// Method prints all the patient transactions with 
        /// OPD on the console. 
        /// </summary>
        public void GetAllPatientTransactions()
        {
            foreach (KeyValuePair<Tuple<Patient, DateTime>, Disease> item in contactInstance)
            {
                Console.WriteLine("{0} {1}, {2}, {3}", item.Key.Item1.FirstName, item.Key.Item1.LastName, 
                    item.Key.Item2, item.Value.MedicalIssue);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int NumberOfTransactions()
        {
            return contactInstance.Count; 
        }
    }
}
