using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    /// <summary>
    /// Class representing an animal in the shelter.
    /// </summary>
    class Animal
    {
        /// <summary>
        /// The maximum length of the chip registration number.
        /// </summary>
        private const int chipRegistrationNumberMaxLength = 5;

        // Backing fields for properties, see actual properties for their description.
        private string chipRegistrationNumber;
        private SimpleDate dateOfBirth;
        private string name;
        private bool isReserved;

        /// <summary>
        /// A five digit number containing the registration number of the animal.
        /// </summary>
        public string ChipRegistrationNumber
        {
            get { return chipRegistrationNumber; }
        }

        /// <summary>
        /// Date of birth of the animal. Contains null if unknown.
        /// </summary>
        public SimpleDate DateOfBirth
        {
            get { return dateOfBirth; }
        }

        /// <summary>
        /// The name of the animal. Contains null if unknown.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Is the animal reserved yes or no.
        /// An animal in the shelter can be reserved by the future owner. 
        /// </summary>
        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }

        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">A five digit number containing the chip registration 
        /// number of the animal. If the given number contains less than 5 digits, then it will be
        /// stuffed with zero's from the left. So "5" becomes "00005". If the given number contains
        /// more than 5 digits, then the number is truncated after the 5th position. So "1234567"
        /// becomes "12345"</param>
        /// <param name="dateOfBirth">The date of birth of the animal or null if unknown</param>
        /// <param name="name">The name of the animal or null if unknown</param>
        public Animal(string chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            if (chipRegistrationNumber.Length < chipRegistrationNumberMaxLength)
            {
                this.chipRegistrationNumber
                    = chipRegistrationNumber.PadLeft(chipRegistrationNumberMaxLength, '0');
            }
            else if (chipRegistrationNumber.Length > chipRegistrationNumberMaxLength)
            {
                this.chipRegistrationNumber
                    = chipRegistrationNumber.Substring(0, chipRegistrationNumberMaxLength);
            }
            else
            {
                this.chipRegistrationNumber = chipRegistrationNumber;
            }

            this.dateOfBirth = dateOfBirth;
            this.name = name;
            isReserved = false;
        }

        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: DateOfBirth will be "00-00-0000" if unknown or the actual date otherwise.
        ///                 Name will be "noname" if unknown or the actual name otherwise.
        ///                 IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
        public override string ToString()
        {
            string dateOfBirthString;
            if (dateOfBirth == null)
            {
                dateOfBirthString = "00-00-0000";
            }
            else
            {
                dateOfBirthString = dateOfBirth.ToString();
            }

            string nameString;
            if (name == null || name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = name;
            }

            string IsReservedString;
            if (isReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                + ", " + dateOfBirthString
                + ", " + nameString
                + ", " + IsReservedString;

            return info;
        }
    }
}
