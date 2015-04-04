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
            this.components = new System.ComponentModel.Container();
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.lChipRegistrationNumber = new System.Windows.Forms.Label();
            this.lDateOfBirth = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.tbChipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.gbAnimal = new System.Windows.Forms.GroupBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.lSpecialData = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpLastWalked = new System.Windows.Forms.DateTimePicker();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.lGender = new System.Windows.Forms.Label();
            this.ddbGender = new System.Windows.Forms.ComboBox();
            this.gbAnimals = new System.Windows.Forms.GroupBox();
            this.lbFreeAnimals = new System.Windows.Forms.ListBox();
            this.cmsFreeAnimals = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reserverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReservedAnimals = new System.Windows.Forms.ListBox();
            this.cmsReserved = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bRandomLoop = new System.Windows.Forms.Button();
            this.gbAnimal.SuspendLayout();
            this.layout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAnimals.SuspendLayout();
            this.cmsFreeAnimals.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsReserved.SuspendLayout();
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
            this.animalTypeComboBox.Size = new System.Drawing.Size(136, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(154, 11);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(130, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // lChipRegistrationNumber
            // 
            this.lChipRegistrationNumber.AutoSize = true;
            this.lChipRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lChipRegistrationNumber.Location = new System.Drawing.Point(3, 0);
            this.lChipRegistrationNumber.Name = "lChipRegistrationNumber";
            this.lChipRegistrationNumber.Size = new System.Drawing.Size(130, 21);
            this.lChipRegistrationNumber.TabIndex = 3;
            this.lChipRegistrationNumber.Text = "Chip Registration Number:";
            this.lChipRegistrationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lDateOfBirth
            // 
            this.lDateOfBirth.AutoSize = true;
            this.lDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lDateOfBirth.Location = new System.Drawing.Point(3, 21);
            this.lDateOfBirth.Name = "lDateOfBirth";
            this.lDateOfBirth.Size = new System.Drawing.Size(130, 21);
            this.lDateOfBirth.TabIndex = 4;
            this.lDateOfBirth.Text = "Date Of Birth:";
            this.lDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lName.Location = new System.Drawing.Point(3, 42);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(130, 21);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name:";
            this.lName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbChipRegistrationNumber
            // 
            this.tbChipRegistrationNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChipRegistrationNumber.Location = new System.Drawing.Point(139, 3);
            this.tbChipRegistrationNumber.MaxLength = 5;
            this.tbChipRegistrationNumber.Name = "tbChipRegistrationNumber";
            this.tbChipRegistrationNumber.Size = new System.Drawing.Size(124, 20);
            this.tbChipRegistrationNumber.TabIndex = 7;
            // 
            // gbAnimal
            // 
            this.gbAnimal.Controls.Add(this.layout);
            this.gbAnimal.Location = new System.Drawing.Point(12, 39);
            this.gbAnimal.Name = "gbAnimal";
            this.gbAnimal.Size = new System.Drawing.Size(272, 126);
            this.gbAnimal.TabIndex = 8;
            this.gbAnimal.TabStop = false;
            this.gbAnimal.Text = "Animal";
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.Controls.Add(this.lSpecialData, 0, 4);
            this.layout.Controls.Add(this.lChipRegistrationNumber, 0, 0);
            this.layout.Controls.Add(this.tbChipRegistrationNumber, 1, 0);
            this.layout.Controls.Add(this.lDateOfBirth, 0, 1);
            this.layout.Controls.Add(this.tbName, 1, 2);
            this.layout.Controls.Add(this.lName, 0, 2);
            this.layout.Controls.Add(this.dtpBirthday, 1, 1);
            this.layout.Controls.Add(this.panel1, 1, 4);
            this.layout.Controls.Add(this.lGender, 0, 3);
            this.layout.Controls.Add(this.ddbGender, 1, 3);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(3, 16);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Size = new System.Drawing.Size(266, 107);
            this.layout.TabIndex = 13;
            // 
            // lSpecialData
            // 
            this.lSpecialData.AutoSize = true;
            this.lSpecialData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSpecialData.Location = new System.Drawing.Point(3, 84);
            this.lSpecialData.Name = "lSpecialData";
            this.lSpecialData.Size = new System.Drawing.Size(130, 23);
            this.lSpecialData.TabIndex = 14;
            this.lSpecialData.Text = "Special Data";
            this.lSpecialData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(139, 45);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(124, 20);
            this.tbName.TabIndex = 9;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd-MM-yyy";
            this.dtpBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(139, 24);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(124, 20);
            this.dtpBirthday.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpLastWalked);
            this.panel1.Controls.Add(this.tbBadHabits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(139, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 17);
            this.panel1.TabIndex = 16;
            // 
            // dtpLastWalked
            // 
            this.dtpLastWalked.CustomFormat = "dd-MM-yyy";
            this.dtpLastWalked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpLastWalked.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastWalked.Location = new System.Drawing.Point(0, 0);
            this.dtpLastWalked.Name = "dtpLastWalked";
            this.dtpLastWalked.Size = new System.Drawing.Size(124, 20);
            this.dtpLastWalked.TabIndex = 16;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBadHabits.Location = new System.Drawing.Point(0, 0);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(124, 20);
            this.tbBadHabits.TabIndex = 15;
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lGender.Location = new System.Drawing.Point(3, 63);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(130, 21);
            this.lGender.TabIndex = 17;
            this.lGender.Text = "Gender";
            // 
            // ddbGender
            // 
            this.ddbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddbGender.FormattingEnabled = true;
            this.ddbGender.Location = new System.Drawing.Point(139, 66);
            this.ddbGender.Name = "ddbGender";
            this.ddbGender.Size = new System.Drawing.Size(124, 21);
            this.ddbGender.TabIndex = 18;
            // 
            // gbAnimals
            // 
            this.gbAnimals.Controls.Add(this.lbFreeAnimals);
            this.gbAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAnimals.Location = new System.Drawing.Point(3, 3);
            this.gbAnimals.Name = "gbAnimals";
            this.gbAnimals.Size = new System.Drawing.Size(235, 172);
            this.gbAnimals.TabIndex = 9;
            this.gbAnimals.TabStop = false;
            this.gbAnimals.Text = "Availlable Animals";
            // 
            // lbFreeAnimals
            // 
            this.lbFreeAnimals.ContextMenuStrip = this.cmsFreeAnimals;
            this.lbFreeAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFreeAnimals.FormattingEnabled = true;
            this.lbFreeAnimals.Location = new System.Drawing.Point(3, 16);
            this.lbFreeAnimals.Name = "lbFreeAnimals";
            this.lbFreeAnimals.Size = new System.Drawing.Size(229, 153);
            this.lbFreeAnimals.TabIndex = 0;
            // 
            // cmsFreeAnimals
            // 
            this.cmsFreeAnimals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserverToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsFreeAnimals.Name = "cmsFreeAnimals";
            this.cmsFreeAnimals.ShowImageMargin = false;
            this.cmsFreeAnimals.Size = new System.Drawing.Size(90, 48);
            // 
            // reserverToolStripMenuItem
            // 
            this.reserverToolStripMenuItem.Name = "reserverToolStripMenuItem";
            this.reserverToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.reserverToolStripMenuItem.Text = "Reserve";
            this.reserverToolStripMenuItem.Click += new System.EventHandler(this.tsmiReserveAnimal_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.tsmiDeleteFreeAnimal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbReservedAnimals);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(244, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserved Animals";
            // 
            // lbReservedAnimals
            // 
            this.lbReservedAnimals.ContextMenuStrip = this.cmsReserved;
            this.lbReservedAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReservedAnimals.FormattingEnabled = true;
            this.lbReservedAnimals.Location = new System.Drawing.Point(3, 16);
            this.lbReservedAnimals.Name = "lbReservedAnimals";
            this.lbReservedAnimals.Size = new System.Drawing.Size(229, 153);
            this.lbReservedAnimals.TabIndex = 0;
            // 
            // cmsReserved
            // 
            this.cmsReserved.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsReserved.Name = "cmsFreeAnimals";
            this.cmsReserved.ShowImageMargin = false;
            this.cmsReserved.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "Undo Reservation";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tsmiUndoReservation_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.tsmiDeleteReservedAnimal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbAnimals, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(290, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 178);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // bRandomLoop
            // 
            this.bRandomLoop.Location = new System.Drawing.Point(12, 168);
            this.bRandomLoop.Name = "bRandomLoop";
            this.bRandomLoop.Size = new System.Drawing.Size(75, 25);
            this.bRandomLoop.TabIndex = 12;
            this.bRandomLoop.Text = "Some Loop";
            this.bRandomLoop.UseVisualStyleBackColor = true;
            this.bRandomLoop.Click += new System.EventHandler(this.bRandomLoop_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 202);
            this.Controls.Add(this.bRandomLoop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbAnimal);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.MinimumSize = new System.Drawing.Size(541, 216);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.gbAnimal.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAnimals.ResumeLayout(false);
            this.cmsFreeAnimals.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cmsReserved.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Label lChipRegistrationNumber;
        private System.Windows.Forms.Label lDateOfBirth;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbChipRegistrationNumber;
        private System.Windows.Forms.GroupBox gbAnimal;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.Label lSpecialData;
        private System.Windows.Forms.GroupBox gbAnimals;
        private System.Windows.Forms.ListBox lbFreeAnimals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpLastWalked;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbReservedAnimals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip cmsFreeAnimals;
        private System.Windows.Forms.ToolStripMenuItem reserverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsReserved;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.ComboBox ddbGender;
        private System.Windows.Forms.Button bRandomLoop;

    }
}

