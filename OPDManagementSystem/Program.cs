using OPDManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var disease = new Disease("bone-fracture", true);
            var historyInstance = new PatientHistory();

            var p = new Patient(74565, "Tony", "Stark");

            var ip = new InternationalPatient(7456, "Insurance-details-644sdf");
            
            historyInstance.AddPatientTransaction(ip, disease); 
            historyInstance.AddPatientTransaction(p, disease);

            historyInstance.GetAllPatientTransactions();
            Console.WriteLine(historyInstance.NumberOfTransactions());  
        }
    }
}
