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
//Description: Lab 4.4 - Design a simple form

namespace Lab_4._4_Natalia_Herrera
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = 0;

            try
            {
                txtLetterGrade.Text = "";
                numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message);
                txtNumberGrade.Text = "0";
                txtNumberGrade.Focus();
            }  

            /*
            if (cboValues.SelectedItem != null)
            {
                txtNumberGrade.Text = cboValues.SelectedItem.ToString();
            }*/
           

            //decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);
           

            string letterGrade = "";
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            txtLetterGrade.Text = letterGrade;

            txtNumberGrade.Focus();

        }

        private void frmCalculateGrade_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cboValues.Items.Add(i);
            }
        }

        private void cboValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLetterGrade.Text = "0";
            txtNumberGrade.Text = cboValues.Text;
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            cboValues.Text = txtNumberGrade.Text;
        }
    }
}
