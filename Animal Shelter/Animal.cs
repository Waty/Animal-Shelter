using System;

namespace AnimalShelter
{
    /// <summary>
    ///     Class representing an animal in the shelter.
    /// </summary>
    internal abstract class Animal : IPricable, IComparable<Animal>
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
        /// <param name="gender">The gender of the animal</param>
        protected Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, Gender gender)
        {
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            Gender = gender;
            Reserved = false;
        }

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
        ///     The gender of the animal
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        ///     Is the animal reserved yes or no.
        ///     An animal in the shelter can be reserved by the future owner.
        /// </summary>
        public bool Reserved { get; set; }

        /// <summary>
        ///     Compares the current object with another object of the same type.
        /// </summary>
        /// <returns>
        ///     A value that indicates the relative order of the objects being compared. The return value has the following
        ///     meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This
        ///     object is equal to <paramref name="other" />. Greater than zero This object is greater than
        ///     <paramref name="other" />.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public int CompareTo(Animal other)
        {
            return ChipRegistrationNumber - other.ChipRegistrationNumber;
        }

        public abstract double Price { get; }

        /// <summary>
        ///     Retrieves information about this animal
        /// </summary>
        /// <returns>
        ///     A string containing the information of this animal.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                ChipRegistrationNumber.ToString("D5"),
                DateOfBirth == null ? "00-00-0000" : DateOfBirth.ToString(),
                string.IsNullOrEmpty(Name) ? "noname" : Name,
                Reserved ? "reserved" : "not reserved",
                Price.ToString("C"),
                Gender);
        }
    }

    internal enum Gender
    {
        Male,
        Female
    }
}