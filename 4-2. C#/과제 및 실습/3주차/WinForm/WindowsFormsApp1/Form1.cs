using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char operator1 = char.Parse(tbxOperator.Text);
            double operand1 = double.Parse(tbxOperand1.Text);
            double operand2 = double.Parse(tbxOperand2.Text);
            /*
            if (operator1 == '+')
            {
                double sum = operand1 + operand2;
                lblResult.Text = sum.ToString("0.###");
            }
            else if (operator1 == '-')
            {
                double minus = operand1 - operand2;
                lblResult.Text = minus.ToString("0.###");
            }
            else if (operator1 == '*')
            {
                double multiple = operand1 * operand2;
                lblResult.Text = multiple.ToString("0.###");
            }
            else if (operator1 == '/')
            {
                double division = operand1 / operand2;
                lblResult.Text = division.ToString("0.###");
            }
            else if (operator1 == '%')
            {
                double remainder = operand1 % operand2;
                lblResult.Text = remainder.ToString("0.###");
            }
            else
            {
                lblResult.Text = "계산 불가";
            }
            */

            switch (operator1)
            {
                case '+':
                    double sum = operand1 + operand2;
                    lblResult.Text = sum.ToString("0.###");
                    break;
                case '-':
                    double minus = operand1 - operand2;
                    lblResult.Text = minus.ToString("0.###");
                    break;
                case '*':
                    double multiple = operand1 * operand2;
                    lblResult.Text = multiple.ToString("0.###");
                    break;
                case '/':
                    double division = operand1 / operand2;
                    lblResult.Text = division.ToString("0.###");
                    break;
                case '%':
                    double remainder = operand1 % operand2;
                    lblResult.Text = remainder.ToString("0.###");
                    break;
            }
            }
        }
}
