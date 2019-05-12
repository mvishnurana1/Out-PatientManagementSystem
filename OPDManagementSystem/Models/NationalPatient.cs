namespace OPDManagementSystem.Models
{
    public class NationalPatient : Patient
    {
        public NationalPatient(string medicareInfo, long ID) : base(ID)
        {
            MedicareInfo = medicareInfo; 
        }

        public string MedicareInfo { get; set; }
    }

}
