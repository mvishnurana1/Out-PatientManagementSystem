namespace OPDManagementSystem.Models
{
    public class NationalPatient : Patient
    {
        public NationalPatient()
        {}

        public NationalPatient(long id) : base(id) 
        {}

        public NationalPatient(long ID, string firstName, string lastName)
            : base(ID, firstName, lastName)
        {}

        public NationalPatient(long ID, string firstName, string lastName, 
            string medicareDetail) : base(ID, firstName, lastName)
        {
            MedicareInfo = medicareDetail; 
        }

        public NationalPatient(string medicareInfo, long ID) : base(ID)
        {
            MedicareInfo = medicareInfo; 
        }

        override
        public Patient Clone()
        {
            var ret = new NationalPatient();

            ret.PatientID = this.PatientID;
            ret.FirstName = this.FirstName;
            ret.LastName = this.LastName;
            ret.DateOfBirth = this.DateOfBirth;
            ret.GetAddress = this.GetAddress;

            return ret;
        }

        public string MedicareInfo { get; set; }
    }

}
