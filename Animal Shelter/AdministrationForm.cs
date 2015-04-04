using System;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        ///     The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;

        /// <summary>
        ///     Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;
        }

        /// <summary>
        ///     Create an Animal object and store it in the administration.
        ///     If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        ///     If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            string registrationNumber = tbChipRegistrationNumber.Text;
            var dateOfBirth = new SimpleDate(dtpBirthday.Value);
            string name = tbName.Text;

            switch (animalTypeComboBox.Text)
            {
                case "Dog":
                    animal = new Dog(registrationNumber, dateOfBirth, name,
                        new SimpleDate(DateTime.Parse(tbSpecialData.Text)));
                    break;

                case "Cat":
                    animal = new Cat(registrationNumber, dateOfBirth, name, tbSpecialData.Text);
                    break;

                default:
                    animal = null;
                    break;
            }
        }

        /// <summary>
        ///     Show the info of the animal referenced by the 'animal' field.
        /// </summary>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (animal != null)
            {
                MessageBox.Show(animal.ToString(), "Info");
            }
            else
            {
                MessageBox.Show("There was no animal");
            }
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (animalTypeComboBox.Text)
            {
                case "Dog":
                    lSpecialData.Text = "Last Walk Date";
                    break;

                case "Cat":
                    lSpecialData.Text = "Bad Habits";
                    break;

                default:
                    lSpecialData.Text = "Special Data";
                    break;
            }
        }
    }
}