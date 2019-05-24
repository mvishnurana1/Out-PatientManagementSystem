using System;

namespace OPDManagementSystem.Models
{
    public class Disease
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Disease() : this("", false){}

        /// <summary>
        /// Constructor overloaded
        /// </summary>
        /// <param name="title"></param>
        /// <param name="chronic"></param>
        public Disease(string title, Boolean chronic)
        {
            MedicalIssue = title;
            Chronic = chronic; 
        }


        public String MedicalIssue { get; set; }
        public Boolean Chronic { get; set; }
    }
}
