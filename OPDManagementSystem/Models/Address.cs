using System;

namespace OPDManagementSystem.Models
{
    public class Address
    {
        // Constructor chaining 
        /// <summary>
        /// default constructor
        /// </summary>
        public Address() : this(0, "", "", 0)
        { }

        /// <summary>
        /// constructor over-load-1
        /// </summary>
        /// <param name="hNumber"></param>
        /// <param name="streetName"></param>
        /// <param name="suburb"></param>
        /// <param name="postcode"></param>
        public Address(int hNumber, string streetName, string suburb, int postcode)
        {
            HouseNumber = hNumber;
            StreetName1 = streetName;
            Suburb = suburb;
            PostCode = postcode;
        }

        /// <summary>
        /// constructor over-load-2
        /// </summary>
        /// <param name="hNumber"></param>
        /// <param name="streetName"></param>
        /// <param name="streetName2"></param>
        /// <param name="suburb"></param>
        /// <param name="postcode"></param>
        public Address(int hNumber, string streetName, string streetName2, string suburb, int postcode)
        {
            HouseNumber = hNumber;
            StreetName1 = streetName;
            StreetName2 = streetName2;
            Suburb = suburb;
            PostCode = postcode;
        }

        /// <summary>
        /// Address model of the patient House number. 
        /// </summary>
        public int HouseNumber { get; set; }

        /// <summary>
        /// Address model of the patient Street1 
        /// </summary>
        public string StreetName1 { get; set; }

        /// <summary>
        /// Optional address field of the address model
        /// </summary>
        public string StreetName2 { get; set; }

        /// <summary>
        /// Suburb field of the address 
        /// </summary>
        public string Suburb { get; set;}

        /// <summary>
        /// post-code field of the address. 
        /// </summary>
        public int PostCode { get; set; }

        /// <summary>
        /// Returns the address and converts it to string. 
        /// </summary>
        /// <returns></returns>
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
