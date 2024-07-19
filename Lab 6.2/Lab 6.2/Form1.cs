using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_6._2
{
    // name: Natalia Andrea Herrera
    // date: 2023-10-29
    // description: Lab 6.2 regex
    public partial class FormRegex : Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            // Validation logic for email address
            string email = textBox1.Text; // Get email address from the textbox

            // Regular expression for email validation
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            //other option
            //Regex emailRegex = new Regex(@"^([\w\.%\+\-]+)@([a-zA-Z0-9.-]+)\.[a-zA-Z]{2,4}$");
            //Regex emailRegex = new Regex(@"^([\w\]$");@([a-zA-Z0-9.-]+)\.[a-zA-Z]{2,4}$");


            // Check if the input email matches the specified pattern
            bool isEmailValid = emailRegex.IsMatch(email);

            // Display appropriate message based on validation result
            if (isEmailValid)
            {
                MessageBox.Show("Email is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Focus();
        }

        private void btnDeleteExtra_Click(object sender, EventArgs e)
        {
            // Get the input text from textBox1
            string inputText = textBox1.Text;
                
            // Remove all spaces from the input text
            string cleanedText = Regex.Replace(inputText, @"\s", "");

            // Display the cleaned text in a message box
            MessageBox.Show($"Cleaned Text: '{cleanedText}'", "Cleaned Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update textBox1 with the cleaned text
            textBox1.Text = cleanedText;
        }

        private void btnValidatePC_Click(object sender, EventArgs e)
        {
            // Get the postal code input from textBox1
            string postalCode = textBox1.Text;

            // Regular expressions for postal code validation
            Regex postalCodeRegex = new Regex(@"^([A-Z][0-9][A-Z])([0-9][A-Z][0-9])$");
            Regex postalCodeWithSeparatorRegex = new Regex(@"^([A-Z]\d[A-Z])([\s\-])?([\d][A-Z][\d])$");

            // Check if the input postal code matches the specified patterns
            bool isValidPostalCode = postalCodeRegex.IsMatch(postalCode) || postalCodeWithSeparatorRegex.IsMatch(postalCode);

            // Display appropriate message based on validation result
            if (isValidPostalCode)
            {
                MessageBox.Show("Postal code is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid postal code. Please enter a valid postal code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteLetters_Click(object sender, EventArgs e)
        {
            // Get the input text from textBox1
            string inputText = textBox1.Text;

            // Remove letters 'a', 'b', 'c', and 'd' from the input text
            string cleanedText = Regex.Replace(inputText, "[abcd]", "");

            // Update textBox1 with the cleaned text 
            textBox1.Text = cleanedText;

            // Display the cleaned text in a message box
            MessageBox.Show($"Cleaned Text: {cleanedText}", "Cleaned Text", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            // Get the input text from textBox1
            string inputText = textBox1.Text;

            // Split the input text into an array of words using space as the separator
            string[] words = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Do something with the 'words' array, display them in a MessageBox
            string wordsString = string.Join(", ", words);
            MessageBox.Show($"Array of words: {wordsString}", "Words Array", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            // Validation logic
            string userName = txtUser.Text; // Get user name from the textbox
            string address = txtAddress.Text; // Get address from the textbox
            string city = txtCity.Text; // Get city from the textbox
            string province = txtProv.Text; // Get province from the textbox
            string postalCode = txtPC.Text; // Get postal code from the textbox
            string phoneNumber = txtTel.Text; // Get phone number from the textbox

            // Regular expressions for validation
            Regex userNameRegex = new Regex(@"^[a-zA-Z ]{2,20}$"); // Validates user name for the user name have minimum 2 letters, and maximum 20 (space included)
            Regex addressRegex = new Regex(@"^\d{1,4} [a-zA-Z ]{1,20}$"); // Validates address for the address, must start with 1 to 4 digits, a space, then up to 20 letters
            Regex cityRegex = new Regex(@"^([Mm]ontreal)$"); // Validates city
            Regex provinceRegex = new Regex(@"^([Qq][Cc])$"); // Validates province accept only Qc, QC, qc, qC
            Regex postalCodeRegex = new Regex(@"^([A-Z]\d[A-Z])\s?(\d[A-Z]\d)$"); // Validates postal code Postal code (A9A9A9, A9A 9A9, A9A-9A9)”^([A - Z][0 - 9][A - Z])([0 - 9][A - Z][0 - 9])$” = (A9A9A9) @”^([A - Z][\d][A - Z])([\s\-])?([\d][A - Z][\d])$” = (A9A9A9 or A9A 9A9 or A9A - 9A9)
            Regex phoneRegex = new Regex(@"^\d{3} \d{3}[- ]\d{4}$"); // Validates phone number tart with 3 digits, a space, other 3 digits, another space or dash, and ending with 4 digits.

            // Check if all input fields match the specified patterns
            bool isValid = userNameRegex.IsMatch(userName) &&
                           addressRegex.IsMatch(address) &&
                           cityRegex.IsMatch(city) &&
                           provinceRegex.IsMatch(province) &&
                           postalCodeRegex.IsMatch(postalCode) &&
                           phoneRegex.IsMatch(phoneNumber);

            // Display appropriate message based on validation result
            if (isValid)
            {
                MessageBox.Show("Validation successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Validation failed. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app.?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }
    }
}
