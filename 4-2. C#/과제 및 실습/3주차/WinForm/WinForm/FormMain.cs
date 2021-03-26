using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double opr1 = 0.0;
            double opr2 = 0.0;
            if (double.TryParse((tbxOperand1.Text), out opr1) && double.TryParse((tbxOperand2.Text), out opr2))
            {
                if (tbxOperator.Text == "+")
                {
                    double sum = opr1 + opr2;
                    lblResult.Text = sum.ToString("0.000");
                }
                else if (tbxOperator.Text == "-")
                {
                    double minus = opr1 - opr2;
                    lblResult.Text = minus.ToString("0.000");
                }
                else if (tbxOperator.Text == "/")
                {
                    double divide = opr1 / opr2;
                    lblResult.Text = divide.ToString("0.000");
                }
                else if (tbxOperator.Text == "*")
                {
                    double multiply = opr1 * opr2;
                    lblResult.Text = multiply.ToString("0.000");
                }
                else if (tbxOperator.Text == "%")
                {
                    double remainder = opr1 % opr2;
                    lblResult.Text = remainder.ToString("0.000");
                }
                else
                {
                    lblResult.Text = "계산불가(연산자)";
                }
                /*switch (tbxOperator.Text)
                {
                    case "+":
                        double sum = opr1 + opr2;
                        lblResult.Text = sum.ToString("0.###");
                        break;
                    case "-":
                        double minus = opr1 - opr2;
                        lblResult.Text = minus.ToString("0.###");
                        break;
                    case "/":
                        double divide = opr1 / opr2;
                        lblResult.Text = divide.ToString("0.###");
                        break;
                    case "*":
                        double multiply = opr1 * opr2;
                        lblResult.Text = multiply.ToString("0.###");
                        break;
                    case "%":
                        double remainder = opr1 % opr2;
                        lblResult.Text = remainder.ToString("0.###");
                        break;
                    default:
                        lblResult.Text = "계산불가(연산자)";
                        break;
                }*/
            }
            else
            {
                lblResult.Text = "계산 불가(피연산자)";
            }
        }
    }
}