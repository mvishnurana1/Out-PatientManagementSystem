namespace OPDManagementSystem.Models
{
    public class NationalPatient : Patient
    {
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

        public string MedicareInfo { get; set; }
    }

}
