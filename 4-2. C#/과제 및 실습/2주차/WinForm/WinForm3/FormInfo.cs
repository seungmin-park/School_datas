using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        string[] number = new string[5];
        string[] name = new string[5];
        double[] score = new double[5];
        int index = 0;

        private void btnNew_Click(object sender, EventArgs e)
        {
            //신규입력
            if (index >= 5)
            {
                MessageBox.Show("수강인원이 가득찼어요");
                return;//메소드 종료
            }
            else
            {
            number[index] = tbxNumber.Text;
            name[index] = tbxName.Text;
            score[index] = double.Parse(tbxScore.Text);

            tbxOutput.Text = $"{number[index]}--{name[index]}--{score[index]}";

            index++;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //입력된 모든 학생 출력
            tbxOutput.Text = "";
            //tbxOutput = string.Empty;
            //tbxOutput.Clear();
            for(int i = 0; i < index; i++)
            {
                tbxOutput.Text += $"{number[i]}--{name[i]}--{score[i]}";
                tbxOutput.Text += Environment.NewLine;
            }
        }
    }
}
