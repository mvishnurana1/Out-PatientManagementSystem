using System;
using System.Collections.Generic;

namespace OPDManagementSystem.Models
{
    public class PatientHistory
    {
        private IDictionary<DateTime, Disease> contactInstance = new Dictionary<DateTime, Disease>();

        /// <summary>
        /// The method takes add the patient transaction 
        /// with the hospital to add a log to the history. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="disease"></param>
        public void AddPatientTransaction(DateTime date, Disease disease)
        {
            contactInstance.Add(date, disease);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="disease"></param>
        public void RemovePatientTransaction(DateTime date, Disease disease)
        {
            contactInstance.Remove(date);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public Disease GetTransactionInformation(DateTime date)
        {
            var disease = new Disease();

            if (contactInstance.TryGetValue(date, out disease))
            {
                return (disease);
            }
            else
            {
                return disease = null;
            }
        }

        /// <summary>
        /// Method prints all the patient transactions with 
        /// OPD on the console. 
        /// </summary>
        public void GetAllPatientTransactions()
        {
            foreach (KeyValuePair<DateTime, Disease> item in contactInstance)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value.MedicalIssue);
            }
        }

        public int NumberOfTransactions()
        {
            return contactInstance.Count; 
        }
    }
}
