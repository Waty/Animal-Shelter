namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.lChipRegistrationNumber = new System.Windows.Forms.Label();
            this.lDateOfBirth = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbChipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbSpecialData = new System.Windows.Forms.TextBox();
            this.lSpecialData = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbAnimal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 10);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // lChipRegistrationNumber
            // 
            this.lChipRegistrationNumber.AutoSize = true;
            this.lChipRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lChipRegistrationNumber.Location = new System.Drawing.Point(3, 0);
            this.lChipRegistrationNumber.Name = "lChipRegistrationNumber";
            this.lChipRegistrationNumber.Size = new System.Drawing.Size(130, 25);
            this.lChipRegistrationNumber.TabIndex = 3;
            this.lChipRegistrationNumber.Text = "Chip Registration Number:";
            this.lChipRegistrationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDateOfBirth
            // 
            this.lDateOfBirth.AutoSize = true;
            this.lDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateOfBirth.Location = new System.Drawing.Point(3, 25);
            this.lDateOfBirth.Name = "lDateOfBirth";
            this.lDateOfBirth.Size = new System.Drawing.Size(130, 25);
            this.lDateOfBirth.TabIndex = 4;
            this.lDateOfBirth.Text = "Date Of Birth:";
            this.lDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lName.Location = new System.Drawing.Point(3, 50);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(130, 25);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name:";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbChipRegistrationNumber
            // 
            this.tbChipRegistrationNumber.Location = new System.Drawing.Point(139, 3);
            this.tbChipRegistrationNumber.Name = "tbChipRegistrationNumber";
            this.tbChipRegistrationNumber.Size = new System.Drawing.Size(118, 20);
            this.tbChipRegistrationNumber.TabIndex = 7;
            // 
            // gbAnimal
            // 
            this.gbAnimal.Controls.Add(this.tableLayoutPanel1);
            this.gbAnimal.Location = new System.Drawing.Point(12, 39);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(272, 127);
            this.gbAnimal.TabIndex = 8;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbSpecialData, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lSpecialData, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lChipRegistrationNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbChipRegistrationNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lDateOfBirth, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpBirthday, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 100);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tbSpecialData
            // 
            this.tbSpecialData.Location = new System.Drawing.Point(139, 78);
            this.tbSpecialData.Name = "tbSpecialData";
            this.tbSpecialData.Size = new System.Drawing.Size(118, 20);
            this.tbSpecialData.TabIndex = 15;
            // 
            // lSpecialData
            // 
            this.lSpecialData.AutoSize = true;
            this.lSpecialData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSpecialData.Location = new System.Drawing.Point(3, 75);
            this.lSpecialData.Name = "lSpecialData";
            this.lSpecialData.Size = new System.Drawing.Size(130, 25);
            this.lSpecialData.TabIndex = 14;
            this.lSpecialData.Text = "Special Data";
            this.lSpecialData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 20);
            this.tbName.TabIndex = 9;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(139, 28);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(118, 20);
            this.dtpBirthday.TabIndex = 13;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 177);
            this.Controls.Add(this.gbAnimal);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.gbAnimal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Label lChipRegistrationNumber;
        private System.Windows.Forms.Label lDateOfBirth;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbChipRegistrationNumber;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbSpecialData;
        private System.Windows.Forms.Label lSpecialData;

    }
}

