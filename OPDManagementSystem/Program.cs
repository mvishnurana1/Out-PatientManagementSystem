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

            historyInstance.AddPatientTransaction(new DateTime(2012, 12, 10, 12, 45, 03), disease);

            historyInstance.GetAllPatientTransactions();

            Console.WriteLine(historyInstance.NumberOfTransactions());  
        }
    }
}
