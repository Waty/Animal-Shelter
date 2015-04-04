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
            animalTypeComboBox.SelectedIndex = 0;
            CreateFakeData();
        }

        private void CreateFakeData()
        {
            AddAnimal(new Dog(12345, new SimpleDate(DateTime.Today.AddYears(-5)), "Hector",
                new SimpleDate(DateTime.Now)));
            AddAnimal(new Cat(12456, new SimpleDate(DateTime.Today.AddYears(-7)), "Henk", "Shits in the hallway"));
        }

        private void AddAnimal(Animal a)
        {
            administration.Add(a);
            if (a.Reserved)
            {
                lbReservedAnimals.Items.Add(a);
            }
            else
            {
                lbFreeAnimals.Items.Add(a);
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
                a = new Dog(registrationNumber, dateOfBirth, name, new SimpleDate(dtpLastWalked.Value));
            }
            else
            {
                a = new Cat(registrationNumber, dateOfBirth, name, tbBadHabits.Text);
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
    }
}