using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPDManagementSystem.Models
{
    public abstract class Patient : Person
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
            GetAddress = address; 
        }

        public long PatientID { get; set; }
        //todo: protected set
        //protected long PatientID { set; }
        
        public String BloodGroup { get; set; }
        
        public PatientHistory GetHistory { get; set; }

        public abstract Patient Clone();

        public string PatientToString()
        {
            return this.PatientID + " " + this.FirstName + " " + this.LastName + " " + this.DateOfBirth 
                +" "+this.GetAddress.AddressToString();
        }
    }
}
