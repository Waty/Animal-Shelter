namespace AnimalShelter
{
    /// <summary>
    ///     Class representing an animal in the shelter.
    /// </summary>
    internal abstract class Animal : IPricable
    {
        /// <summary>
        ///     The maximum length of the chip registration number.
        /// </summary>
        private const int ChipRegistrationNumberLength = 5;

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
        protected Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            Reserved = false;
        }

        // Backing fields for properties, see actual properties for their description.

        /// <summary>
        ///     A five digit number containing the registration number of the animal.
        /// </summary>
        public int ChipRegistrationNumber { get; private set; }

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

        public abstract double Price { get; }

        private static string FormatRegistrationNumber(string chipRegistrationNumber)
        {
            if (chipRegistrationNumber.Length < ChipRegistrationNumberLength)
            {
                return chipRegistrationNumber.PadLeft(ChipRegistrationNumberLength, '0');
            }

            if (chipRegistrationNumber.Length > ChipRegistrationNumberLength)
            {
                return chipRegistrationNumber.Substring(0, ChipRegistrationNumberLength);
            }

            return chipRegistrationNumber;
        }

        /// <summary>
        ///     Retrieves information about this animal
        /// </summary>
        /// <returns>
        ///     A string containing the information of this animal.
        /// </returns>
        public override string ToString()
        {
            string dateOfBirthString = DateOfBirth == null ? "00-00-0000" : DateOfBirth.ToString();
            string nameString = string.IsNullOrEmpty(Name) ? "noname" : Name;
            string isReservedString = Reserved ? "reserved" : "not reserved";

            return string.Format("{0}, {1}, {2}, {3}, {4}", ChipRegistrationNumber.ToString("D5"), dateOfBirthString, nameString,
                isReservedString, Price.ToString("C"));
        }
    }
}