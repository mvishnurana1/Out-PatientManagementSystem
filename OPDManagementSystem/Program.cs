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
            var disease = new Disease("Cancer", true);
            var disease1 = new Disease("HIV", true);
            var historyInstance = new PatientHistory();
            var p = new Patient(74565, "Tony", "Stark");

            historyInstance.AddPatientTransaction(p, new DateTime(2015, 03, 21), disease);
            historyInstance.AddPatientTransaction(p, new DateTime(2015, 04, 22), disease1);
            historyInstance.GetAllPatientTransactions();

            Console.WriteLine(historyInstance.NumberOfTransactions());

            historyInstance.RemovePatientTransaction(p, new DateTime(2015, 03, 21));

            historyInstance.GetAllPatientTransactions();
            Console.WriteLine(historyInstance.NumberOfTransactions());

           // Console.WriteLine(historyInstance.CheckTransactionLog()); 
        }
    }
}
