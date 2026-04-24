using System;
using System.Collections.Generic;
using System.Text;

namespace SectionB_Question2
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            CalculateAge();
        }

        private void CalculateAge()
        {
            if (IDNumber.Length >= 6 && IDNumber.All(char.IsDigit))
            {
                int yy = int.Parse(IDNumber.Substring(0, 2));

                int currentYear = DateTime.Now.Year;
                int currentCentury = currentYear / 100;
                int currentYearTwoDigits = currentYear % 100;

                int birthYear = (yy <= currentYearTwoDigits) ? (2000 + yy) : (1900 + yy);

                Age = currentYear - birthYear;
            }
            else
            {
                Age = -1; 
            }
        }

        public string ValidateID()
        {
            if (string.IsNullOrWhiteSpace(IDNumber)) return "Invalid: ID is empty.";
            if (IDNumber.Length != 13) return "Invalid: ID must be exactly 13 digits.";
            if (!IDNumber.All(char.IsDigit)) return "Invalid: ID must be numeric only.";
            if (Age < 0 || Age > 120) return "Invalid: Unrealistic age calculated.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}
