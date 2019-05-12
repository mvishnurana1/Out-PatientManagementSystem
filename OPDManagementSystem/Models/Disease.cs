using System;

namespace OPDManagementSystem.Models
{
    public class Disease
    {
        public Disease() : this("", false){}

        public Disease(string title, Boolean chronic)
        {
            MedicalIssue = title;
            Chronic = chronic; 
        }

        public String MedicalIssue { get; set; }
        public Boolean Chronic { get; set; }
    }
}
