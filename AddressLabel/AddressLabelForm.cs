/*Luke Groesbeck
Spring 2026
RCET 2265
Project Address Label
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/AddressLabel.git
*/

namespace AddressLabel
{
    public partial class AddressLabelForm : Form
    {
        public AddressLabelForm()
        {
            InitializeComponent();
            // intialize the form components
            SetDefaults();
            // set all the text boxes and display label to empty
        }
        void SetDefaults()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StreetAddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            DisplayLabel.Text = "";
        }

        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {
            ValidateFields();
            //make sure all the fields are filled out
            DisplayLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n" +
                $"{StreetAddressTextBox.Text}\n" +
                $"{CityTextBox.Text}, {StateTextBox.Text} {ZipCodeTextBox.Text}";
            // display the address label in the display label
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            // Clear all text boxes and reset to defaults
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Close the form/program
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                FirstNameTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text != "")
            {
                LastNameTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                LastNameTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void StreetAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StreetAddressTextBox.Text != "")
            {
                StreetAddressTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                StreetAddressTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                CityTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StateTextBox.Text != "")
            {
                StateTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                StateTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ZipCodeTextBox.Text != "")
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = true;
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.Pink;
                DisplayLabelButton.Enabled = false;
            }
            // change the color of the text box to light yellow if there is text, pink if there is not
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
