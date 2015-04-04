using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter
{
    internal class Administration
    {
        private readonly List<Animal> animals = new List<Animal>();

        public bool Add(Animal animal)
        {
            if (FindAnimal(animal.ChipRegistrationNumber) == null)
            {
                return false;
            }

            animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            Animal animal = FindAnimal(chipRegistrationNumber);
            if (animal == null)
            {
                return false;
            }

            animals.Remove(animal);
            return true;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            return animals.FirstOrDefault(a => a.ChipRegistrationNumber == chipRegistrationNumber);
        }
    }
}