using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Natalia Andrea Herrera Espinosa
// Date: 2023-10-16
// Description: Lab 6.1 - Exercise - Working with strings.

namespace Lab_6._1
{
    public partial class StringHandling : Form
    {
        public StringHandling()
        {
            InitializeComponent();
        }


        string fullName; //global value
        string phoneNumber;
        private void StringHandling_Load(object sender, EventArgs e)
        {
            fullName = "john doe kent";
            textBox1.Text = fullName;

            phoneNumber = "(514) 123-4567";
            textBox2.Text = phoneNumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_parse_name_Click(object sender, EventArgs e)
        {
            // Split the input full name into an array of nameParts based on space ' ' delimiter.
            string[] nameParts = textBox1.Text.Split(' ');

            // Extract the first name from the first element of the nameParts array.
            string firstName = nameParts[0];

            // Extract the last name from the last element of the nameParts array.
            string lastName = nameParts[nameParts.Length - 1];

            // Extract middle names by joining elements from index 1 to nameParts.Length - 2 of the nameParts array.
            string middleNames = string.Join(" ", nameParts.Skip(1).Take(nameParts.Length - 2));

            // Create a copy of middleNames for later use in its original format.
            string resultMiddle = middleNames;

            // Capitalize the first letter of the first name and convert the othersLetters to lowercase.
            if (!string.IsNullOrEmpty(firstName))
            {
                char firstLetter = char.ToUpper(firstName[0]);
                string othersLetters = firstName.Substring(1).ToLower();
                firstName = firstLetter + othersLetters;
            }

            // Capitalize the first letter of the last name and convert the othersLetters to lowercase.
            if (!string.IsNullOrEmpty(lastName))
            {
                char firstLetter = char.ToUpper(lastName[0]);
                string rest = lastName.Substring(1).ToLower();
                lastName = firstLetter + rest;
            }

            // If there are middle names, capitalize the first letter of each middle name and convert the othersLetters to lowercase.
            if (!string.IsNullOrEmpty(middleNames))
            {
                // Split middle names into an array and process each name individually.
                string[] middle = middleNames.Split(' ');
                for (int i = 0; i < middle.Length; i++)
                {
                    if (!string.IsNullOrEmpty(middle[i]))
                    {
                        char firstLetter = char.ToUpper(middle[i][0]);
                        string rest = middle[i].Substring(1).ToLower();
                        middle[i] = firstLetter + rest;
                    }
                }
                // Join the processed middle names back into a single string.
                resultMiddle = string.Join(" ", middle);
            }

            // Display formatted names in a message box and update the input text box with the formatted full name.
            if (firstName != lastName)
            {
                MessageBox.Show("First Name: ".PadRight(30) + firstName +
                    "\nMiddle Name: ".PadRight(27) + resultMiddle +
                    "\nLast Name: ".PadRight(30) + lastName);
                textBox1.Text = firstName + " " + resultMiddle + " " + lastName;
            }
            else
            {
                // If first name and last name are the same, display only the first name in the message box.
                MessageBox.Show("First Name: ".PadRight(30) + firstName +
                "\n\nMiddle Name: ".PadRight(27) +
                "\n\nLast Name: ".PadRight(30));
                textBox1.Text = firstName;
            }

        }

        private void btn_phone_number_Click(object sender, EventArgs e)
        {
            // Get the phone number input from the text box.
            string phoneNumberText = textBox2.Text;

            // Define a regular expression pattern for validating the phone number format: (XXX) XXX-XXXX
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";

            // Check if the input phone number matches the specified pattern.
            if (Regex.IsMatch(phoneNumberText, pattern))
            {
                // Remove parentheses, hyphens, and spaces to get only the digits.
                string dig = phoneNumberText.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                // Replace spaces with hyphens to convert the phone number to standard format.
                string standard = phoneNumberText.Replace("(", "").Replace(")", "").Replace(" ", "-");

                // Display the original, digits only, and standard format phone numbers in a message box.
                MessageBox.Show("Entered:".PadRight(35) + phoneNumberText +
                    "\n\nDigits only:".PadRight(35) + dig +
                    "\n\nStandard format:".PadRight(29) + standard);
            }
            else
            {
                // If the input does not match the expected format, display an error message and focus on the input box.
                MessageBox.Show(" Invalid Number. Try again.");
                textBox2.Focus();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
