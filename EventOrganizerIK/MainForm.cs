using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace EventOrganizerV2
{
    public partial class MainForm : Form
    {
        private EventManager eventManager;


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            groupBoxNewEvent.Enabled = true;
            groupBoxAddParticipant.Enabled = false;
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList; //not able to write, just choose from list
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Country));
            comboBoxCountry.SelectedIndex = 0; //doesnt show anything from the start    
        }

        //Create Event - button
        private void btnCreateNewEvent_Click(object sender, EventArgs e)
        {
            bool ok = ReadNewEventInput(
            out string title,
            out double costPerParticipant,
            out double feePerParticipant);

            if (!ok)
                return;

            //Create a new object of EventManager
            eventManager = new EventManager();

            eventManager.Title = title;
            eventManager.CostPerPerson = costPerParticipant;
            eventManager.FeePerPerson = feePerParticipant;

            //The named event is shown as a title in the window
            this.Text = eventManager.Title + " By Isabella Katz";

            groupBoxAddParticipant.Enabled = true;
            listBoxParticipants.Items.Clear();

            DisplayEventEconomy();
            MessageBox.Show("A new event has been created.");
        }

        //Method to read input for a new event
        private bool ReadNewEventInput(
            out string title,
            out double costPerParticipant,
            out double feePerParticipant)
        {
            title = txtBoxEventTitel.Text.Trim();

            // Title is required
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter an event title.");
                costPerParticipant = 0.0;
                feePerParticipant = 0.0;
                return false;
            }

            // Cost/Fee are optional: default to 0.0 if empty/invalid
            if (!double.TryParse(txtBoxCostPerParticipant.Text, out costPerParticipant))
                costPerParticipant = 0.0;

            if (!double.TryParse(txtBoxFeePerParticipant.Text, out feePerParticipant))
                feePerParticipant = 0.0;

            // No negative values allowed
            if (costPerParticipant < 0 || feePerParticipant < 0)
            {
                MessageBox.Show("Cost and fee must be 0 or greater.");
                return false;
            }

            return true;
        }


        //Button - Add Participant
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (eventManager == null)
            {
                MessageBox.Show("Please create the event first.");
                return;
            }

            bool ok = ReadPersonalDetails(
                out string firstName,
                out string lastName,
                out string street,
                out string zipCode,
                out string city,
                out Country country);

            if (!ok)
                return;

            Address address = new Address(street, zipCode, city, country);
            Participant participant = new Participant(firstName, lastName, address);

            bool added = eventManager.Participants.AddParticipant(participant);

            if (!added)
            {
                MessageBox.Show("Could not add participant.");
                return;
            }

            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxStreet.Clear();
            txtBoxZipCode.Clear();
            txtBoxCity.Clear();
            comboBoxCountry.SelectedIndex = 0;

            UpdateParticipantList();
            DisplayEventEconomy();
        }

        //Reads input from user
        private bool ReadPersonalDetails(
            out string firstName,
            out string lastName,
            out string street,
            out string zipCode,
            out string city,
            out Country country)
        {
            firstName = txtBoxFirstName.Text.Trim();
            lastName = txtBoxLastName.Text.Trim();
            street = txtBoxStreet.Text.Trim();
            zipCode = txtBoxZipCode.Text.Trim();
            city = txtBoxCity.Text.Trim();

            if (comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a country");
                country = default;
                return false;
            }

            country = (Country)comboBoxCountry.SelectedItem;

            bool ok =
                !string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(street) &&
                !string.IsNullOrWhiteSpace(zipCode) &&
                !string.IsNullOrWhiteSpace(city);

            if (!ok)

                MessageBox.Show("Please fill in all fields.");

            return ok;
        }

        //GUI UPDATE
        private void UpdateParticipantList()
        {
            listBoxParticipants.Items.Clear();

            foreach (string s in eventManager.Participants.GetParticipantInfo())
                listBoxParticipants.Items.Add(s);
        }

        //Method to display summary of event economy
        private void DisplayEventEconomy()
        {
            if (eventManager == null)
                return;

            int nbrOfParticipants = eventManager.NumberOfParticipants;
            textBoxNbrOfParticipants.Text = nbrOfParticipants.ToString();

            //total cost
            double totalCost = eventManager.CalcTotalCost();
            textBoxTotalCost.Text = totalCost.ToString("N2");

            //total fee
            double totalFees = eventManager.CalcTotalFees();
            textBoxTotalFees.Text = totalFees.ToString("N2");

            //surplus/deficit
            double surplusOrDeficit = eventManager.CalcSurplusOrDeficit();
            textBoxSurplusOrDeficit.Text = surplusOrDeficit.ToString("N2");
        }

        //Button - Change participant info
        private void btnChangeParticipant_Click(object sender, EventArgs e)
        {
            if (eventManager == null)
            {
                MessageBox.Show("Please create an event first");
                return;
            }

            int index = listBoxParticipants.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select a guest to edit.");
                return;
            }

            bool ok = ReadPersonalDetails(
                out string firstName,
                out string lastName,
                out string street,
                out string zipCode,
                out string city,
                out Country country);
            if (!ok)
                return;

            Address address = new Address(street, zipCode, city, country);
            Participant participantIn = new Participant(firstName, lastName, address);

            bool changed = eventManager.Participants.ChangeParticipantAt(participantIn, index);
            
            if (!changed)
            {
                MessageBox.Show("Could not edit participant information.");
                return;
            }

            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxStreet.Clear();
            txtBoxZipCode.Clear();
            txtBoxCity.Clear();
            comboBoxCountry.SelectedIndex = 0;
            
            UpdateParticipantList();
            DisplayEventEconomy();
        }

        //Button - Delete participant from event
        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            if (eventManager == null)
            {
                MessageBox.Show("Please create an event first.");
                return;
            }

            int index = listBoxParticipants.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Please select a guest to remove.");
            }

            bool deleted = eventManager.Participants.DeleteParticipantAt(index);
            if (!deleted)
            {
                MessageBox.Show("Could not delete participant.");
                return;
            }

            //Update GUI
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxStreet.Clear();
            txtBoxZipCode.Clear();
            txtBoxCity.Clear();
            comboBoxCountry.SelectedIndex = 0;
            UpdateParticipantList();
            DisplayEventEconomy();
        }


        //Method to get all information about a participant when you want to change 
        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventManager == null)
                return;

            int index = listBoxParticipants.SelectedIndex;
            if (index < 0)
                return;

            Participant p = eventManager.Participants.GetParticipantAt(index);
            if (p == null)
                return;

            txtBoxFirstName.Text = p.FirstName;
            txtBoxLastName.Text = p.LastName;

            if (p.Address != null)
            {
                txtBoxStreet.Text = p.Address.Street;
                txtBoxZipCode.Text = p.Address.ZipCode;
                txtBoxCity.Text = p.Address.City;
                comboBoxCountry.SelectedItem = p.Address.Country;
            }
        }
    }
}
