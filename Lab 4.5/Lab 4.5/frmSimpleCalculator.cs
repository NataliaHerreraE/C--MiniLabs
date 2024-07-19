using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4._5
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        

        private void frmSimpleCalculator_Load(object sender, EventArgs e)
        {
            calc = new Calc();
        }

        Calc calc;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calc calc = new Calc();
            double n1, n2;


            try
            {
                n1 = Convert.ToDouble(txtNum1.Text);

                try
                {
                    n2 = Convert.ToDouble(txtNum2.Text);

                    textBox1.Text = calc.Add(n1, n2).ToString();
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
        
        private void btnSub_Click(object sender, EventArgs e)
        {
           
            double n1, n2;


            try
            {
                n1 = Convert.ToDouble(txtNum1.Text);

                try
                {
                    n2 = Convert.ToDouble(txtNum2.Text);

                    textBox2.Text = calc.Sub(n1, n2).ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox2.Text = "0";
                    textBox2.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox2.Text = "0";
                textBox2.Focus();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
          
            double n1, n2;

            try
            {
                n1 = Convert.ToDouble(txtNum1.Text);

                try
                {
                    n2 = Convert.ToDouble(txtNum2.Text);
                    calc.N1 = n1;
                    calc.N2 = n2;
                    textBox3.Text = calc.Mul().ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox3.Text = "0";
                    textBox3.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox3.Text = "0";
                textBox3.Focus();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double n1, n2;

            try
            {
                n1 = Convert.ToDouble(txtNum1.Text);

                try
                {
                    n2 = Convert.ToDouble(txtNum2.Text);
                    calc.N1 = n1;
                    calc.N2 = n2;
                    textBox4.Text = calc.Div().ToString();
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox4.Text = "0";
                    textBox4.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox4.Text = "0";
                textBox4.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            double n1, n2;
            string operation;
            try
            {
                n1 = Convert.ToDouble(txtNum1.Text);

                try
                {
                    n2 = Convert.ToDouble(txtNum2.Text);
                    operation= cboOperations.SelectedItem.ToString();

                    if (operation == "+")
                    {
                        textBox1.Text = calc.Add(n1, n2).ToString();
                    }
                    else if  (operation == "-")
                    {
                        textBox2.Text = calc.Sub(n1, n2).ToString();
                    }
                    else if (operation == "*")
                    {
                        calc.N1 = n1;
                        calc.N2 = n2;
                        textBox3.Text = calc.Mul().ToString();
                    }
                    else if (operation == "/")
                    {
                        calc.N1 = n1;
                        calc.N2 = n2;
                        textBox4.Text = calc.Div().ToString();
                    }

                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                    textBox4.Text = "0";
                    textBox4.Focus();
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                textBox4.Text = "0";
                textBox4.Focus();
            }
        }
    }


}
