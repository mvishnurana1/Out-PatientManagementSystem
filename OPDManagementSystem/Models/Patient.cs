using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDManagementSystem.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address PatientAddress { get; set; }
    }
}
