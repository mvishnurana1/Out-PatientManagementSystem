namespace OPDManagementSystem.Models
{
    public class InternationalPatient : Patient
    {
        public InternationalPatient(long ID, string detail) : base(ID)
        {
            InsuraceDetail = detail; 
        }

        public string InsuraceDetail { get; set; }
    }
}
