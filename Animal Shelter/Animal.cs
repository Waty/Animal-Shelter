namespace AnimalShelter
{
    /// <summary>
    ///     Class representing an animal in the shelter.
    /// </summary>
    internal class Animal
    {
        /// <summary>
        ///     The maximum length of the chip registration number.
        /// </summary>
        private const int ChipRegistrationNumberMaxLength = 5;

        /// <summary>
        ///     Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">
        ///     A five digit number containing the chip registration
        ///     number of the animal. If the given number contains less than 5 digits, then it will be
        ///     stuffed with zero's from the left. So "5" becomes "00005". If the given number contains
        ///     more than 5 digits, then the number is truncated after the 5th position. So "1234567"
        ///     becomes "12345"
        /// </param>
        /// <param name="dateOfBirth">The date of birth of the animal or null if unknown</param>
        /// <param name="name">The name of the animal or null if unknown</param>
        public Animal(string chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            if (chipRegistrationNumber.Length < ChipRegistrationNumberMaxLength)
            {
                ChipRegistrationNumber = chipRegistrationNumber.PadLeft(ChipRegistrationNumberMaxLength, '0');
            }
            else if (chipRegistrationNumber.Length > ChipRegistrationNumberMaxLength)
            {
                ChipRegistrationNumber = chipRegistrationNumber.Substring(0, ChipRegistrationNumberMaxLength);
            }
            else
            {
                ChipRegistrationNumber = chipRegistrationNumber;
            }

            DateOfBirth = dateOfBirth;
            Name = name;
            Reserved = false;
        }

        // Backing fields for properties, see actual properties for their description.

        /// <summary>
        ///     A five digit number containing the registration number of the animal.
        /// </summary>
        public string ChipRegistrationNumber { get; private set; }

        /// <summary>
        ///     Date of birth of the animal. Contains null if unknown.
        /// </summary>
        public SimpleDate DateOfBirth { get; private set; }

        /// <summary>
        ///     The name of the animal. Contains null if unknown.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///     Is the animal reserved yes or no.
        ///     An animal in the shelter can be reserved by the future owner.
        /// </summary>
        public bool Reserved { get; set; }

        /// <summary>
        ///     Retrieve information about this animal
        ///     Note: Every class inherits (automagically) from the 'Object' class,
        ///     which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>
        ///     A string containing the information of this animal.
        /// </returns>
        public override string ToString()
        {
            string dateOfBirthString = DateOfBirth == null ? "00-00-0000" : DateOfBirth.ToString();
            string nameString = string.IsNullOrEmpty(Name) ? "noname" : Name;
            string isReservedString = Reserved ? "reserved" : "not reserved";

            return string.Format("{0}, {1}, {2}, {3}", ChipRegistrationNumber, dateOfBirthString, nameString,
                isReservedString);
        }
    }
}