namespace OPDManagementSystem.Models
{
    public class Doctor : Person
    {
        public int DoctorID { get; set; }

        public string PatientToString()
        {
            return this.DoctorID + " " + this.FirstName + " " + this.LastName + " " + this.DateOfBirth
                + " " + this.GetAddress.AddressToString();
        }
    }
}
