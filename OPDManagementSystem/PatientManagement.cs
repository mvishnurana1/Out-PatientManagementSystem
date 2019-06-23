using OPDManagementSystem.Models;
using System.Collections.Generic;
using System; 

namespace OPDManagementSystem
{
    public class PatientManagement
    {
        private List<Patient> record = new List<Patient>();

        /// <summary>
        /// The function adds patient to the list if not 
        /// contained in the list and returns true, else
        /// false. 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool AddPatient(Patient patient)
        {
            if(!PatientIsPresent(patient))
            {
                record.Add(patient.Clone());
                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// The function checks if a patient is already 
        /// present in the list and returns true/false. 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool PatientIsPresent(Patient patient)
        {
            if(record.Contains(patient))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// The method removes a patient from the list 
        /// and returns true. 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool RemovePatient(Patient patient)
        {
            if(PatientIsPresent(patient))
            {
                record.Remove(patient);
                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// Function returns the number of 
        /// patients in the list. 
        /// </summary>
        /// <returns></returns>
        public int PatientCount()
        {
            return record.Count; 
        }
    }
}
