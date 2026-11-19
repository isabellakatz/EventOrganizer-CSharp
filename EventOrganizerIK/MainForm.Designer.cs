namespace EventOrganizerV2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxNewEvent = new GroupBox();
            btnCreateEvent = new Button();
            txtBoxFeePerParticipant = new TextBox();
            txtBoxCostPerParticipant = new TextBox();
            txtBoxEventTitel = new TextBox();
            lblFeePerParticipant = new Label();
            lblCostPerParticipant = new Label();
            lblEventTitle = new Label();
            groupBoxEventEconomy = new GroupBox();
            textBoxSurplusOrDeficit = new TextBox();
            textBoxTotalFees = new TextBox();
            textBoxTotalCost = new TextBox();
            textBoxNbrOfParticipants = new TextBox();
            lblSurplusOrDeficit = new Label();
            lblTotalFees = new Label();
            lblTotalCost = new Label();
            lblNbrOfParticipants = new Label();
            groupBoxAddParticipant = new GroupBox();
            btnAddParticipant = new Button();
            comboBoxCountry = new ComboBox();
            txtBoxCity = new TextBox();
            txtBoxZipCode = new TextBox();
            txtBoxStreet = new TextBox();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            lblCountry = new Label();
            lblCity = new Label();
            lblZipCode = new Label();
            lblStreet = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            groupBoxParticipants = new GroupBox();
            lblAddress = new Label();
            lblParticipant = new Label();
            listBoxParticipants = new ListBox();
            btnChangeParticipant = new Button();
            btnDeleteParticipant = new Button();
            groupBoxNewEvent.SuspendLayout();
            groupBoxEventEconomy.SuspendLayout();
            groupBoxAddParticipant.SuspendLayout();
            groupBoxParticipants.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNewEvent
            // 
            groupBoxNewEvent.Controls.Add(btnCreateEvent);
            groupBoxNewEvent.Controls.Add(txtBoxFeePerParticipant);
            groupBoxNewEvent.Controls.Add(txtBoxCostPerParticipant);
            groupBoxNewEvent.Controls.Add(txtBoxEventTitel);
            groupBoxNewEvent.Controls.Add(lblFeePerParticipant);
            groupBoxNewEvent.Controls.Add(lblCostPerParticipant);
            groupBoxNewEvent.Controls.Add(lblEventTitle);
            groupBoxNewEvent.Location = new Point(54, 31);
            groupBoxNewEvent.Name = "groupBoxNewEvent";
            groupBoxNewEvent.Size = new Size(651, 248);
            groupBoxNewEvent.TabIndex = 0;
            groupBoxNewEvent.TabStop = false;
            groupBoxNewEvent.Text = "New Event";
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.Location = new Point(287, 199);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(167, 34);
            btnCreateEvent.TabIndex = 6;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.UseVisualStyleBackColor = true;
            btnCreateEvent.Click += btnCreateNewEvent_Click;
            // 
            // txtBoxFeePerParticipant
            // 
            txtBoxFeePerParticipant.Location = new Point(246, 138);
            txtBoxFeePerParticipant.Name = "txtBoxFeePerParticipant";
            txtBoxFeePerParticipant.Size = new Size(150, 31);
            txtBoxFeePerParticipant.TabIndex = 5;
            // 
            // txtBoxCostPerParticipant
            // 
            txtBoxCostPerParticipant.Location = new Point(246, 94);
            txtBoxCostPerParticipant.Name = "txtBoxCostPerParticipant";
            txtBoxCostPerParticipant.Size = new Size(150, 31);
            txtBoxCostPerParticipant.TabIndex = 4;
            // 
            // txtBoxEventTitel
            // 
            txtBoxEventTitel.Location = new Point(246, 41);
            txtBoxEventTitel.Name = "txtBoxEventTitel";
            txtBoxEventTitel.Size = new Size(324, 31);
            txtBoxEventTitel.TabIndex = 3;
            // 
            // lblFeePerParticipant
            // 
            lblFeePerParticipant.AutoSize = true;
            lblFeePerParticipant.Location = new Point(19, 144);
            lblFeePerParticipant.Name = "lblFeePerParticipant";
            lblFeePerParticipant.Size = new Size(159, 25);
            lblFeePerParticipant.TabIndex = 2;
            lblFeePerParticipant.Text = "Fee per participant";
            // 
            // lblCostPerParticipant
            // 
            lblCostPerParticipant.AutoSize = true;
            lblCostPerParticipant.Location = new Point(19, 94);
            lblCostPerParticipant.Name = "lblCostPerParticipant";
            lblCostPerParticipant.Size = new Size(168, 25);
            lblCostPerParticipant.TabIndex = 1;
            lblCostPerParticipant.Text = "Cost per participant";
            // 
            // lblEventTitle
            // 
            lblEventTitle.AutoSize = true;
            lblEventTitle.Location = new Point(19, 47);
            lblEventTitle.Name = "lblEventTitle";
            lblEventTitle.Size = new Size(89, 25);
            lblEventTitle.TabIndex = 0;
            lblEventTitle.Text = "Event title";
            // 
            // groupBoxEventEconomy
            // 
            groupBoxEventEconomy.Controls.Add(textBoxSurplusOrDeficit);
            groupBoxEventEconomy.Controls.Add(textBoxTotalFees);
            groupBoxEventEconomy.Controls.Add(textBoxTotalCost);
            groupBoxEventEconomy.Controls.Add(textBoxNbrOfParticipants);
            groupBoxEventEconomy.Controls.Add(lblSurplusOrDeficit);
            groupBoxEventEconomy.Controls.Add(lblTotalFees);
            groupBoxEventEconomy.Controls.Add(lblTotalCost);
            groupBoxEventEconomy.Controls.Add(lblNbrOfParticipants);
            groupBoxEventEconomy.Location = new Point(731, 40);
            groupBoxEventEconomy.Name = "groupBoxEventEconomy";
            groupBoxEventEconomy.Size = new Size(640, 239);
            groupBoxEventEconomy.TabIndex = 1;
            groupBoxEventEconomy.TabStop = false;
            groupBoxEventEconomy.Text = "Event Economy";
            // 
            // textBoxSurplusOrDeficit
            // 
            textBoxSurplusOrDeficit.Location = new Point(271, 159);
            textBoxSurplusOrDeficit.Name = "textBoxSurplusOrDeficit";
            textBoxSurplusOrDeficit.ReadOnly = true;
            textBoxSurplusOrDeficit.Size = new Size(150, 31);
            textBoxSurplusOrDeficit.TabIndex = 7;
            // 
            // textBoxTotalFees
            // 
            textBoxTotalFees.Location = new Point(271, 116);
            textBoxTotalFees.Name = "textBoxTotalFees";
            textBoxTotalFees.ReadOnly = true;
            textBoxTotalFees.Size = new Size(150, 31);
            textBoxTotalFees.TabIndex = 6;
            // 
            // textBoxTotalCost
            // 
            textBoxTotalCost.Location = new Point(271, 79);
            textBoxTotalCost.Name = "textBoxTotalCost";
            textBoxTotalCost.ReadOnly = true;
            textBoxTotalCost.Size = new Size(150, 31);
            textBoxTotalCost.TabIndex = 5;
            // 
            // textBoxNbrOfParticipants
            // 
            textBoxNbrOfParticipants.Location = new Point(271, 42);
            textBoxNbrOfParticipants.Name = "textBoxNbrOfParticipants";
            textBoxNbrOfParticipants.ReadOnly = true;
            textBoxNbrOfParticipants.Size = new Size(150, 31);
            textBoxNbrOfParticipants.TabIndex = 4;
            // 
            // lblSurplusOrDeficit
            // 
            lblSurplusOrDeficit.AutoSize = true;
            lblSurplusOrDeficit.Location = new Point(33, 162);
            lblSurplusOrDeficit.Name = "lblSurplusOrDeficit";
            lblSurplusOrDeficit.Size = new Size(126, 25);
            lblSurplusOrDeficit.TabIndex = 3;
            lblSurplusOrDeficit.Text = "Surplus/deficit";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Location = new Point(33, 125);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(86, 25);
            lblTotalFees.TabIndex = 2;
            lblTotalFees.Text = "Total fees";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(33, 85);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(90, 25);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblNbrOfParticipants
            // 
            lblNbrOfParticipants.AutoSize = true;
            lblNbrOfParticipants.Location = new Point(33, 42);
            lblNbrOfParticipants.Name = "lblNbrOfParticipants";
            lblNbrOfParticipants.Size = new Size(196, 25);
            lblNbrOfParticipants.TabIndex = 0;
            lblNbrOfParticipants.Text = "Number of participants";
            // 
            // groupBoxAddParticipant
            // 
            groupBoxAddParticipant.Controls.Add(btnAddParticipant);
            groupBoxAddParticipant.Controls.Add(comboBoxCountry);
            groupBoxAddParticipant.Controls.Add(txtBoxCity);
            groupBoxAddParticipant.Controls.Add(txtBoxZipCode);
            groupBoxAddParticipant.Controls.Add(txtBoxStreet);
            groupBoxAddParticipant.Controls.Add(txtBoxLastName);
            groupBoxAddParticipant.Controls.Add(txtBoxFirstName);
            groupBoxAddParticipant.Controls.Add(lblCountry);
            groupBoxAddParticipant.Controls.Add(lblCity);
            groupBoxAddParticipant.Controls.Add(lblZipCode);
            groupBoxAddParticipant.Controls.Add(lblStreet);
            groupBoxAddParticipant.Controls.Add(lblLastName);
            groupBoxAddParticipant.Controls.Add(lblFirstName);
            groupBoxAddParticipant.Location = new Point(48, 285);
            groupBoxAddParticipant.Name = "groupBoxAddParticipant";
            groupBoxAddParticipant.Size = new Size(519, 349);
            groupBoxAddParticipant.TabIndex = 2;
            groupBoxAddParticipant.TabStop = false;
            groupBoxAddParticipant.Text = "Add participant";
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Location = new Point(241, 300);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(112, 34);
            btnAddParticipant.TabIndex = 17;
            btnAddParticipant.Text = "Add";
            btnAddParticipant.UseVisualStyleBackColor = true;
            btnAddParticipant.Click += btnAddParticipant_Click;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "Sverige", "Danmark", "Norge" });
            comboBoxCountry.Location = new Point(170, 240);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(305, 33);
            comboBoxCountry.TabIndex = 16;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Location = new Point(170, 197);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(305, 31);
            txtBoxCity.TabIndex = 15;
            // 
            // txtBoxZipCode
            // 
            txtBoxZipCode.Location = new Point(170, 156);
            txtBoxZipCode.Name = "txtBoxZipCode";
            txtBoxZipCode.Size = new Size(305, 31);
            txtBoxZipCode.TabIndex = 14;
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.Location = new Point(170, 118);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(305, 31);
            txtBoxStreet.TabIndex = 13;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(170, 72);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(305, 31);
            txtBoxLastName.TabIndex = 12;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(170, 33);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(305, 31);
            txtBoxFirstName.TabIndex = 11;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(23, 243);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 25);
            lblCountry.TabIndex = 9;
            lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(26, 197);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 8;
            lblCity.Text = "City";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(26, 162);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(84, 25);
            lblZipCode.TabIndex = 7;
            lblZipCode.Text = "Zip Code";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(26, 118);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(57, 25);
            lblStreet.TabIndex = 6;
            lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(25, 78);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 39);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // groupBoxParticipants
            // 
            groupBoxParticipants.Controls.Add(lblAddress);
            groupBoxParticipants.Controls.Add(lblParticipant);
            groupBoxParticipants.Controls.Add(listBoxParticipants);
            groupBoxParticipants.Location = new Point(622, 296);
            groupBoxParticipants.Name = "groupBoxParticipants";
            groupBoxParticipants.Size = new Size(749, 338);
            groupBoxParticipants.TabIndex = 3;
            groupBoxParticipants.TabStop = false;
            groupBoxParticipants.Text = "Participants";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(426, 38);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblParticipant
            // 
            lblParticipant.AutoSize = true;
            lblParticipant.Location = new Point(83, 38);
            lblParticipant.Name = "lblParticipant";
            lblParticipant.Size = new Size(94, 25);
            lblParticipant.TabIndex = 1;
            lblParticipant.Text = "Participant";
            // 
            // listBoxParticipants
            // 
            listBoxParticipants.ForeColor = SystemColors.Desktop;
            listBoxParticipants.FormattingEnabled = true;
            listBoxParticipants.ItemHeight = 25;
            listBoxParticipants.Location = new Point(16, 79);
            listBoxParticipants.Name = "listBoxParticipants";
            listBoxParticipants.Size = new Size(715, 204);
            listBoxParticipants.TabIndex = 0;
            listBoxParticipants.SelectedIndexChanged += listBoxParticipants_SelectedIndexChanged;
            // 
            // btnChangeParticipant
            // 
            btnChangeParticipant.Location = new Point(839, 585);
            btnChangeParticipant.Name = "btnChangeParticipant";
            btnChangeParticipant.Size = new Size(112, 34);
            btnChangeParticipant.TabIndex = 4;
            btnChangeParticipant.Text = "Change";
            btnChangeParticipant.UseVisualStyleBackColor = true;
            btnChangeParticipant.Click += btnChangeParticipant_Click;
            // 
            // btnDeleteParticipant
            // 
            btnDeleteParticipant.Location = new Point(1048, 585);
            btnDeleteParticipant.Name = "btnDeleteParticipant";
            btnDeleteParticipant.Size = new Size(112, 34);
            btnDeleteParticipant.TabIndex = 5;
            btnDeleteParticipant.Text = "Delete";
            btnDeleteParticipant.UseVisualStyleBackColor = true;
            btnDeleteParticipant.Click += btnDeleteParticipant_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 655);
            Controls.Add(btnDeleteParticipant);
            Controls.Add(btnChangeParticipant);
            Controls.Add(groupBoxParticipants);
            Controls.Add(groupBoxAddParticipant);
            Controls.Add(groupBoxEventEconomy);
            Controls.Add(groupBoxNewEvent);
            Name = "MainForm";
            Text = "By Isabella Katz";
            groupBoxNewEvent.ResumeLayout(false);
            groupBoxNewEvent.PerformLayout();
            groupBoxEventEconomy.ResumeLayout(false);
            groupBoxEventEconomy.PerformLayout();
            groupBoxAddParticipant.ResumeLayout(false);
            groupBoxAddParticipant.PerformLayout();
            groupBoxParticipants.ResumeLayout(false);
            groupBoxParticipants.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNewEvent;
        private GroupBox groupBoxEventEconomy;
        private GroupBox groupBoxAddParticipant;
        private GroupBox groupBoxParticipants;
        private Label lblFeePerParticipant;
        private Label lblCostPerParticipant;
        private Label lblEventTitle;
        private TextBox txtBoxFeePerParticipant;
        private TextBox txtBoxCostPerParticipant;
        private TextBox txtBoxEventTitel;
        private Button btnCreateEvent;
        private TextBox textBoxTotalFees;
        private TextBox textBoxTotalCost;
        private TextBox textBoxNbrOfParticipants;
        private Label lblSurplusOrDeficit;
        private Label lblTotalFees;
        private Label lblTotalCost;
        private Label lblNbrOfParticipants;
        private Label lblFirstName;
        private TextBox textBoxSurplusOrDeficit;
        private Label lblCountry;
        private Label lblCity;
        private Label lblZipCode;
        private Label lblStreet;
        private Label lblLastName;
        private Button btnChangeParticipant;
        private Button btnDeleteParticipant;
        private ComboBox comboBoxCountry;
        private TextBox txtBoxCity;
        private TextBox txtBoxZipCode;
        private TextBox txtBoxStreet;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private Label lblAddress;
        private Label lblParticipant;
        private ListBox listBoxParticipants;
        private Button btnAddParticipant;
    }
}
