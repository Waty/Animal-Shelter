﻿namespace AnimalShelter
{
    internal class Dog : Animal
    {
        /// <summary>
        ///     Creates a dog.
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
        /// <param name="lastWalkDate">The date of the last walk with the dog or null if unknown.</param>
        /// <param name="gender">The gender of the Dog</param>
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, SimpleDate lastWalkDate,
            Gender gender)
            : base(chipRegistrationNumber, dateOfBirth, name, gender)
        {
            LastWalkDate = lastWalkDate;
        }

        /// <summary>
        ///     The date of the last walk of the dog. Contains null if unknown.
        /// </summary>
        public SimpleDate LastWalkDate { get; private set; }

        public override double Price
        {
            get
            {
                return ChipRegistrationNumber < 50000
                    ? 200
                    : 350;
            }
        }

        /// <summary>
        ///     Retrieve information about this dog
        ///     Note: Every class inherits (automagically) from the 'Object' class,
        ///     which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>
        ///     A string containing the information of this animal.
        ///     DateOfBirth will be "00-00-0000" if unknown or the actual date otherwise.
        ///     Name will be "noname" if unknown or the actual name otherwise.
        ///     IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///     LastWalkDate will be "00-00-0000" if unknown or the actual date otherwise.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Dog: {0}, {1}", base.ToString(), LastWalkDate ?? new SimpleDate(0, 0, 0));
        }
    }
}