using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._5
{
    internal class Calc
    {
        // Private fields to store the two numbers
        private double n1;
        private double n2;

        // constructor default
        public Calc()
        {

        }

        //constructor with two arguments
        public Calc(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        //get and set to acces to the private fields

        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mul()
        {
            return n1 * n2;
        }

        public double Div()
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            else
            {
                Console.WriteLine("Error: Not valid division by zero.");
                // Not-a-Number for invalid division
                return double.NaN;
            }
        }
    }
}
