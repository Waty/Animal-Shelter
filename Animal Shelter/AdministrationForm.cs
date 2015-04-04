using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        ///     The administration
        /// </summary>
        private readonly Administration administration = new Administration();

        /// <summary>
        ///     Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            ddbGender.DataSource = Enum.GetValues(typeof (Gender));
            ddbGender.SelectedIndex = 0;

            animalTypeComboBox.SelectedIndex = 0;
            CreateFakeData();
        }

        private void CreateFakeData()
        {
            int id = 12345;
            AddAnimal(new Dog(++id, new SimpleDate(), "Hector", new SimpleDate(DateTime.Now), Gender.Male));
            AddAnimal(new Cat(++id, new SimpleDate(), "Henk", "gasdgsasgd", Gender.Male));
            AddAnimal(new Dog(++id, new SimpleDate(), "asgfas", new SimpleDate(DateTime.Now), Gender.Male));
            AddAnimal(new Cat(++id, new SimpleDate(), "asgasdg", "asdgasdg", Gender.Female));
            AddAnimal(new Dog(++id, new SimpleDate(), "asdgfadhfdsh", new SimpleDate(DateTime.Now), Gender.Female));
            AddAnimal(new Cat(++id, new SimpleDate(), "agasdgas", "asgasda", Gender.Female));
            AddAnimal(new Cat(5, new SimpleDate(), "agasdgas", "asgasda", Gender.Female));
        }

        private void AddAnimal(Animal a)
        {
            administration.Add(a);
            if (a.Reserved)
            {
                lbReservedAnimals.Items.Add(a);

                var animals = lbReservedAnimals.Items.Cast<Animal>().ToArray();
                Array.Sort(animals);

                lbReservedAnimals.Items.Clear();
                lbReservedAnimals.Items.AddRange(animals);
            }
            else
            {
                lbFreeAnimals.Items.Add(a);

                var animals = lbFreeAnimals.Items.Cast<Animal>().ToArray();
                Array.Sort(animals);

                lbFreeAnimals.Items.Clear();
                lbFreeAnimals.Items.AddRange(animals);
            }
        }

        /// <summary>
        ///     Create an Animal object and store it in the administration.
        ///     If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        ///     If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            int registrationNumber = Convert.ToInt32(tbChipRegistrationNumber.Text);
            var dateOfBirth = new SimpleDate(dtpBirthday.Value);
            string name = tbName.Text;

            Animal a;
            if (animalTypeComboBox.Text == "Dog")
            {
                a = new Dog(registrationNumber, dateOfBirth, name, new SimpleDate(dtpLastWalked.Value),
                    (Gender) ddbGender.SelectedIndex);
            }
            else
            {
                a = new Cat(registrationNumber, dateOfBirth, name, tbBadHabits.Text, (Gender) ddbGender.SelectedIndex);
            }

            AddAnimal(a);
        }

        /// <summary>
        ///     Changes the UI to enable adding the selected species
        /// </summary>
        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.Text == "Dog")
            {
                lSpecialData.Text = "Last Walk Date";
                dtpLastWalked.Visible = true;
                tbBadHabits.Visible = false;
            }
            else
            {
                lSpecialData.Text = "Bad Habits";
                dtpLastWalked.Visible = false;
                tbBadHabits.Visible = true;
            }
        }

        private void tsmiReserveAnimal_Click(object sender, EventArgs e)
        {
            List<Animal> animals = lbFreeAnimals.SelectedItems.Cast<Animal>().ToList();
            foreach (Animal a in animals)
            {
                a.Reserved = true;
                lbFreeAnimals.Items.Remove(a);
                lbReservedAnimals.Items.Add(a);
            }
        }

        private void tsmiDeleteFreeAnimal_Click(object sender, EventArgs e)
        {
            List<Animal> animals = lbFreeAnimals.SelectedItems.Cast<Animal>().ToList();
            foreach (Animal animal in animals)
            {
                lbFreeAnimals.Items.Remove(animal);
            }
        }

        private void tsmiUndoReservation_Click(object sender, EventArgs e)
        {
            List<Animal> animals = lbReservedAnimals.SelectedItems.Cast<Animal>().ToList();
            foreach (Animal a in animals)
            {
                a.Reserved = false;
                lbFreeAnimals.Items.Add(a);
                lbReservedAnimals.Items.Remove(a);
            }
        }

        private void tsmiDeleteReservedAnimal_Click(object sender, EventArgs e)
        {
            List<Animal> animals = lbReservedAnimals.SelectedItems.Cast<Animal>().ToList();
            foreach (Animal animal in animals)
            {
                lbReservedAnimals.Items.Remove(animal);
            }
        }

        private void bRandomLoop_Click(object sender, EventArgs e)
        {
            foreach (Animal animal in administration.Animals)
            {
                if (animal is Dog)
                {
                    MessageBox.Show("LastWalkDate: " + (animal as Dog).LastWalkDate);
                }
                else if (animal is Cat)
                {
                    MessageBox.Show("BadHabits: " + (animal as Cat).BadHabits);
                }
            }
        }
    }
}