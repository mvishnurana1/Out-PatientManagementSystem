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

        public string InsuraceDetail { get; set; }
    }
}
