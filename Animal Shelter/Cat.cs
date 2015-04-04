namespace AnimalShelter
{
    internal class Cat : Animal
    {
        /// <summary>
        ///     Creates a cat.
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
        /// <param name="badHabits">
        ///     The nasty habbits of the cat (e.g. "scratches the couch")
        ///     or null if none.
        /// </param>
        /// <param name="gender"></param>
        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth, string name, string badHabits, Gender gender)
            : base(chipRegistrationNumber, dateOfBirth, name, gender)
        {
            BadHabits = badHabits;
        }

        // Backing field for property, see actual properties for their description.

        /// <summary>
        ///     Description of the bad habits that the cat shows (e.g. "Scratches the couch").
        ///     or null if the cat shows no bad habits.
        /// </summary>
        public string BadHabits { get; private set; }

        public override double Price
        {
            get
            {
                int price = 60 - BadHabits.Length;
                return price < 20
                    ? 20
                    : price;
            }
        }

        /// <summary>
        ///     Retrieve information about this cat
        ///     Note: Every class inherits (automagically) from the 'Object' class,
        ///     which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>
        ///     A string containing the information of this animal.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Cat: {0}, {1}", base.ToString(), BadHabits ?? "none");
        }
    }
}