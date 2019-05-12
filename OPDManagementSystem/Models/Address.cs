using System;

namespace OPDManagementSystem.Models
{
    public class Address
    {
        // Constructor chaining 
        public Address() : this(0, "", "", 0)
        { }

        public Address(int hNumber, string streetName, string suburb, int postcode)
        {
            HouseNumber = hNumber;
            StreetName1 = streetName;
            Suburb = suburb;
            PostCode = postcode;
        }

        public Address(int hNumber, string streetName, string streetName2, string suburb, int postcode)
        {
            HouseNumber = hNumber;
            StreetName1 = streetName;
            StreetName2 = streetName2;
            Suburb = suburb;
            PostCode = postcode;
        }

        public int HouseNumber { get; set; }
        public string StreetName1 { get; set; }
        public string StreetName2 { get; set; }
        public string Suburb { get; set; }
        public int PostCode { get; set; }

        public string AddressToString()
        {
            if (String.IsNullOrEmpty(StreetName2))
            {
                return HouseNumber + ", " + StreetName1 + ", " + Suburb + ", " + PostCode;
            }
            else
            {
                return HouseNumber + ", " + StreetName1 + ", " + StreetName2 + Suburb + ", " + PostCode;
            }
        }
    }
}
