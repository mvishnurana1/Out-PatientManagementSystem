using System;
using System.Runtime.Serialization; 

namespace OPDManagementSystem.Models
{
    [DataContract]
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

        [DataMember]
        public String MedicalIssue { get; set; }

        [DataMember]
        public Boolean Chronic { get; set; }
    }
}
