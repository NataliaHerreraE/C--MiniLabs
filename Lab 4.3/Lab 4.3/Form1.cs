using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Natalia Andrea Herrera Espinosa
//Date: 2023-10-02
//Description: Lab 4.3 – Create a simple calculator with Windows Form

namespace Lab_4._3
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0, res = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adding_Click(object sender, EventArgs e)
        {
            
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);

                try
                {
                    num2 = Convert.ToDouble(textBox2.Text);
                    res = num1 + num2;
                    textBox3.Text = res.ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Text = "0";
                    textBox1.Focus();
                }
            }
            catch (Exception ex1)
            { 
                MessageBox.Show(ex1.Message);
                textBox1.Text = "0"; 
                textBox1.Focus();
            }
            
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);

                try
                {
                    num2 = Convert.ToDouble(textBox2.Text);
                    res = num1 - num2;
                    textBox4.Text = res.ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Text = "0";
                    textBox1.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox1.Text = "0";
                textBox1.Focus();
            }

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);

                try
                {
                    num2 = Convert.ToDouble(textBox2.Text);
                    res = num1 * num2;
                    textBox5.Text = res.ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Text = "0";
                    textBox1.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox1.Text = "0";
                textBox1.Focus();
            }

        }

        private void Division_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);

                try
                {
                    num2 = Convert.ToDouble(textBox2.Text);
                    res = num1 / num2;
                    textBox6.Text = res.ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox1.Text = "0";
                    textBox1.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox1.Text = "0";
                textBox1.Focus();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App.?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close(); //close the form
            }
            else
            {
                MessageBox.Show("You decide to stay");
            }
        }
    }
}
