/*Luke Groesbeck
Spring 2026
RCET 2265
Project Address Label
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/AddressLabel.git
*/

namespace AddressLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }
        void SetDefaults()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StreetAddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
        }

        private void DisplayLabelButton_Click(object sender, EventArgs e)
        {
            ValidateFields();
            DisplayLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n" +
                $"{StreetAddressTextBox.Text}\n" +
                $"{CityTextBox.Text}, {StateTextBox.Text} {ZipCodeTextBox.Text}";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

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
        }
    }
}
