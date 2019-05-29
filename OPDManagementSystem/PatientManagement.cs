using OPDManagementSystem.Models;
using System.Collections.Generic;

namespace OPDManagementSystem
{
    public class PatientManagement
    {
        private List<Patient> patients = new List<Patient>();
        
        /// <summary>
        /// The method checks if the list already contains
        /// the patient and adds if not. 
        /// </summary>
        /// <param name="patient"></param>
        public bool AddPatient(Patient patient)
        {
            if(!IsPatientFound(patient))
            {
                patients.Add(patient);
                return true; 
            }
            else
            {
                return false; 
            }
        }

        /// <summary>
        /// The function returns all the patients 
        /// contained in the List. 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Patient> GetAllPatients()
        {
            foreach (var patient in patients)
            {
                yield return patient;              
            }
        }

        /// <summary>
        /// The method checks if a patient 
        /// is found in the system. 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool IsPatientFound(Patient patient)
        {
            if(patients.Contains(patient))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The method checks if the patient isFound()
        /// and then removes from the List. 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool RemovePatient(Patient patient)
        {
            if(IsPatientFound(patient))
            {
                patients.Remove(patient);
                return true; 
            }
            else
            {
                return false; 
            } 
        }

        /// <summary>
        /// The method resets the List. 
        /// </summary>
        public void ClearData()
        {
            patients.Clear(); 
        }
    }
}
