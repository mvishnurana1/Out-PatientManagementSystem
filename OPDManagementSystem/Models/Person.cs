using System;
using System.Runtime.Serialization; 

namespace OPDManagementSystem.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public Address GetAddress { get; set; }

        [DataMember]
        public String Gender { get; set; }
    }
}