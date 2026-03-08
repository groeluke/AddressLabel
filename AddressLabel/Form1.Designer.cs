/*Luke Groesbeck
Spring 2026
RCET 2265
Project Address Label
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/AddressLabel.git
*/

namespace AddressLabel
{
    partial class Form1
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
        private void ValidateFields()
        {
            bool valid = true;
            string message = "";
            if (message != "")
            {
                valid = false;
                MessageBox.Show(message);
            }
            // If all validations pass, you can proceed with form submission logic here.
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            StreetAddressTextBox = new TextBox();
            StreetAddressLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            StateLabel = new Label();
            StateTextBox = new TextBox();
            ZipCodeLabel = new Label();
            ZipCodeTextBox = new TextBox();
            MailingAddressGroupBox = new GroupBox();
            DisplayLabelButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            DisplayLabel = new Label();
            AddressLabelGroupBox = new GroupBox();
            MailingAddressGroupBox.SuspendLayout();
            AddressLabelGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(19, 24);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(97, 25);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(17, 53);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(263, 31);
            FirstNameTextBox.TabIndex = 1;
            FirstNameTextBox.Tag = "FirstNameTextBox";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(17, 115);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(263, 31);
            LastNameTextBox.TabIndex = 2;
            LastNameTextBox.Tag = "LastNameTextBox";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(17, 87);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(95, 25);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last Name";
            // 
            // StreetAddressTextBox
            // 
            StreetAddressTextBox.Location = new Point(17, 177);
            StreetAddressTextBox.Name = "StreetAddressTextBox";
            StreetAddressTextBox.Size = new Size(263, 31);
            StreetAddressTextBox.TabIndex = 3;
            StreetAddressTextBox.Tag = "StreetAddressTextBox";
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.Location = new Point(17, 149);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(127, 25);
            StreetAddressLabel.TabIndex = 5;
            StreetAddressLabel.Text = "Street Address";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(17, 239);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(263, 31);
            CityTextBox.TabIndex = 4;
            CityTextBox.Tag = "CityTextBox";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(19, 211);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(19, 273);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 8;
            StateLabel.Text = "State";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(15, 301);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 5;
            StateTextBox.Tag = "StateTextBox";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(19, 335);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(84, 25);
            ZipCodeLabel.TabIndex = 10;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(15, 363);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 6;
            ZipCodeTextBox.Tag = "ZipCodeTextBox";
            // 
            // MailingAddressGroupBox
            // 
            MailingAddressGroupBox.Controls.Add(ZipCodeTextBox);
            MailingAddressGroupBox.Controls.Add(ZipCodeLabel);
            MailingAddressGroupBox.Controls.Add(StateTextBox);
            MailingAddressGroupBox.Controls.Add(StateLabel);
            MailingAddressGroupBox.Controls.Add(CityLabel);
            MailingAddressGroupBox.Controls.Add(CityTextBox);
            MailingAddressGroupBox.Controls.Add(StreetAddressLabel);
            MailingAddressGroupBox.Controls.Add(StreetAddressTextBox);
            MailingAddressGroupBox.Controls.Add(LastNameLabel);
            MailingAddressGroupBox.Controls.Add(LastNameTextBox);
            MailingAddressGroupBox.Controls.Add(FirstNameTextBox);
            MailingAddressGroupBox.Controls.Add(FirstNameLabel);
            MailingAddressGroupBox.Location = new Point(13, 6);
            MailingAddressGroupBox.Name = "MailingAddressGroupBox";
            MailingAddressGroupBox.Size = new Size(318, 426);
            MailingAddressGroupBox.TabIndex = 12;
            MailingAddressGroupBox.TabStop = false;
            MailingAddressGroupBox.Text = "Mailing Address";
            // 
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(336, 352);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(149, 80);
            DisplayLabelButton.TabIndex = 7;
            DisplayLabelButton.Text = "Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            DisplayLabelButton.Click += DisplayLabelButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(491, 352);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(149, 80);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(646, 352);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 80);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(351, 77);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(237, 246);
            DisplayLabel.TabIndex = 18;
            // 
            // AddressLabelGroupBox
            // 
            AddressLabelGroupBox.Controls.Add(DisplayLabel);
            AddressLabelGroupBox.Location = new Point(336, 6);
            AddressLabelGroupBox.Name = "AddressLabelGroupBox";
            AddressLabelGroupBox.Size = new Size(452, 332);
            AddressLabelGroupBox.TabIndex = 14;
            AddressLabelGroupBox.TabStop = false;
            AddressLabelGroupBox.Text = "Address Label";
            AddressLabelGroupBox.Enter += AddressLabelGroupBox_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddressLabelGroupBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DisplayLabelButton);
            Controls.Add(MailingAddressGroupBox);
            Name = "Form1";
            Text = "\"";
            MailingAddressGroupBox.ResumeLayout(false);
            MailingAddressGroupBox.PerformLayout();
            AddressLabelGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox StreetAddressTextBox;
        private Label StreetAddressLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private Label StateLabel;
        private TextBox StateTextBox;
        private Label ZipCodeLabel;
        private TextBox ZipCodeTextBox;
        private GroupBox MailingAddressGroupBox;
        private Button DisplayLabelButton;
        private Button ClearButton;
        private Button ExitButton;
        private Label DisplayLabel;
        private GroupBox AddressLabelGroupBox;
    }
}
