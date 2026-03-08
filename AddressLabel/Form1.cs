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
    }
}
