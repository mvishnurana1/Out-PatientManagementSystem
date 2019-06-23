namespace OPDManagementSystem.Models
{
    public class InternationalPatient : Patient
    {
        public InternationalPatient()
        {}

        public InternationalPatient(long ID) : base(ID)
        {}

        public InternationalPatient(long ID, string name, string lastName) 
            : base(ID, name, lastName)
        {}

        public InternationalPatient(long ID, string name, string lastName, string detail) 
            : base(ID, name, lastName)
        {
            InsuraceDetail = detail; 
        }

        override
        public Patient Clone()
        {
            var ret = new InternationalPatient();
            ret.PatientID = this.PatientID;
            ret.FirstName = this.FirstName;
            ret.LastName = this.LastName;
            ret.DateOfBirth = this.DateOfBirth;
            ret.GetAddress = this.GetAddress;

            return ret;
        }

        public string InsuraceDetail { get; set; }
    }
}
