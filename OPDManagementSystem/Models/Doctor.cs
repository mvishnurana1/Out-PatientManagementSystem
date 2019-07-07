using System.Runtime.Serialization; 

namespace OPDManagementSystem.Models
{
    [DataContract]
    public class Doctor : Person
    {
        [DataMember]
        public int DoctorID { get; set; }

        public string PatientToString()
        {
            return this.DoctorID + " " + this.FirstName + " " + this.LastName + " " + this.DateOfBirth
                + " " + this.GetAddress.AddressToString();
        }
    }
}
