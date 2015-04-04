using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter
{
    internal class Administration
    {
        private readonly List<Animal> animals = new List<Animal>();

        public bool Add(Animal animal)
        {
            if (FindAnimal(animal.ChipRegistrationNumber) != null)
            {
                animals.Add(animal);
                return true;
            }

            return false;
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            Animal animal = FindAnimal(chipRegistrationNumber);
            if (animal != null)
            {
                animals.Remove(animal);
                return true;
            }

            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            return animals.FirstOrDefault(a => a.ChipRegistrationNumber == chipRegistrationNumber);
        }
    }
}