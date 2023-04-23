using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CA3_OisinDuffy
{
    internal class Passengers
    {
        private static string? _lastName;
        private static string? _firstName;
        private static string? _age;
        private static string? _gender;
        private static string? _occupation;
        private static string? _natCountry;
        private static string? _destinationCountry;
        private static string? _portCode;
        private static string? _manifestId;
        private static string? _arrivalDate;


        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string Age { get { return _age; } set { _age = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string Occupation { get { return _occupation; } set { _occupation = value; } }
        public string NatCountry { get { return _natCountry; } set { _natCountry = value; } }
        public string DestinationCountry { get { return _destinationCountry; } set { _destinationCountry = value; } }
        public string PortCode { get { return _portCode; } set { _portCode = value; } }
        public string ManifestID { get { return _manifestId; } set { _manifestId = value; } }
        public string ArrivalDate { get { return _arrivalDate; } set { _arrivalDate = value; } }


        public Passengers(string lastName, string firstName, string age, string gender, string occupation, string natCountry, string destinationCountry, string portCode, string manifestId, string arrivalDate)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Gender = gender;
            Occupation = occupation;
            NatCountry = natCountry;
            DestinationCountry = destinationCountry;
            PortCode = portCode;
            ManifestID = manifestId;
            ArrivalDate = arrivalDate;


        }


    }
}
