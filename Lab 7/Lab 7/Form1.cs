using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//name: Natalia Andrea Herrera Espinosa
//date: 2023-11-12
//Description: Lab 7
namespace Lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string dirPath = @".\Files\";
        string textFilePath = dirPath + "users.txt";
        string binaryFilePath = dirPath + "usersB.txt";
        FileStream fs = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Check if the directory specified by dirPath exists
                if (!Directory.Exists(dirPath))
                {
                    // If the directory doesn't exist, create it
                    Directory.CreateDirectory(dirPath);

                    // Display a message to inform the user that the folder was created
                    MessageBox.Show("Folder created");
                }

                // Set the current date to textBox4 in the "Month Day, Year" format
                textBox4.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            }
            catch (Exception ex)
            {
                // If an exception occurs (e.g., directory creation fails), display an error message
                MessageBox.Show($"Error creating directory: {ex.Message}", "Error");
            }

        }

        private void btn_writeDataToText_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement ensures that the StreamWriter is properly disposed
                using (StreamWriter writer = new StreamWriter(textFilePath, true))
                {
                    // Use the "Month Day, Year" format for the date
                    string data = $"{textBox1.Text}|{textBox2.Text}|{textBox3.Text}|{DateTime.Now.ToString("MMMM dd, yyyy")}";

                    // Write the formatted data to the text file
                    writer.WriteLine(data);
                }

                // Display a success message if writing to the text file is successful
                MessageBox.Show("Data written to text file successfully.", "Success");
            }
            catch (Exception ex)
            {
                // If an exception occurs during the try block, display an error message
                MessageBox.Show($"Error writing to text file: {ex.Message}", "Error");
            }
        }

        private void btn_readDataToText_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement ensures that the StreamReader is properly disposed
                using (StreamReader reader = new StreamReader(textFilePath))
                {
                    // StringBuilder to build the display text
                    StringBuilder displayText = new StringBuilder();

                    // Loop to read up to 3 lines from the text file
                    for (int i = 0; i < 3; i++)
                    {
                        // Read a line from the text file
                        string line = reader.ReadLine();

                        // Check if the line is not null (file not ended)
                        if (line != null)
                        {
                            // Split the line into columns using the '|' character as a delimiter
                            string[] columns = line.Split('|');

                            // Append the formatted information to the displayText StringBuilder
                            displayText.AppendLine($"{columns[0]} {columns[1]}, Age: {columns[2]}");
                        }
                        else
                        {
                            // Break the loop if there are no more lines in the file
                            break;
                        }
                    }

                    // Display the formatted information in a MessageBox
                    MessageBox.Show(displayText.ToString(), "Names and Ages");
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs during the try block, display an error message
                MessageBox.Show($"Error reading from text file: {ex.Message}", "Error");
            }
        }

        private void btn_writeDataToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement ensures that the FileStream and BinaryWriter are properly disposed
                using (FileStream fs = new FileStream(binaryFilePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Write the contents of textBox1.Text as a string to the binary file
                    writer.Write(textBox1.Text);

                    // Write the contents of textBox2.Text as a string to the binary file
                    writer.Write(textBox2.Text);

                    // Parse the contents of textBox3.Text as an integer and write it to the binary file
                    writer.Write(int.Parse(textBox3.Text));
                }

                // Display a success message if writing to the binary file is successful
                MessageBox.Show("Data written to binary file successfully.", "Success");
            }
            catch (Exception ex)
            {
                // If an exception occurs during the try block, display an error message
                MessageBox.Show($"Error writing to binary file: {ex.Message}", "Error");
            }
        }

        private void btn_readDataToBinary_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement ensures that the FileStream and BinaryReader are properly disposed
                using (FileStream fs = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    // StringBuilder to build the display text
                    StringBuilder displayText = new StringBuilder();

                    // Loop to read up to 3 records from the binary file
                    for (int i = 0; i < 3; i++)
                    {
                        // Check if there is a character to read
                        if (reader.PeekChar() != -1)
                        {
                            // Read the first name as a string
                            string firstName = reader.ReadString();

                            // Read the last name as a string
                            string lastName = reader.ReadString();

                            // Read the age as an integer
                            int age = reader.ReadInt32();

                            // Append the formatted information to the displayText StringBuilder
                            displayText.AppendLine($"{firstName} {lastName}, Age: {age}");
                        }
                        else
                        {
                            // Break the loop if there are no more records in the binary file
                            break;
                        }
                    }

                    // Display the formatted information in a MessageBox
                    MessageBox.Show(displayText.ToString(), "Names and Ages (Binary)");
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs during the try block, display an error message
                MessageBox.Show($"Error reading from binary file: {ex.Message}", "Error");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to quit this app? " , "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }

        }


    }
}
