using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDManagementSystem.Models
{
    public abstract class Patient
    {
        public Patient(){}

        public Patient(long id):this(0, "", "")
        {
            PatientID = id; 
        }

        public Patient(long id, string fName, string lName)
        {
            PatientID = id; 
            FirstName = fName;
            LastName = lName; 
        }

        public Patient(long id, string fName, string lName, DateTime dob, Address address)
        {
            PatientID = id;
            FirstName = fName;
            LastName = lName;
            DateOfBirth = dob;
            GetPatientAddress = address; 
        }

        public long PatientID { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address GetPatientAddress { get; set; }
        public PatientHistory GetHistory { get; set; }


        public string PatientToString()
        {
            return this.PatientID + " " + this.FirstName + " " + this.LastName + " " + this.DateOfBirth 
                +" "+this.GetPatientAddress.AddressToString();
        }
    }
}
