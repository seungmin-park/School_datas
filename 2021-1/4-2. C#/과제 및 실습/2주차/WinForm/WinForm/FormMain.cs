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

        //메소드, 이벤트핸들러, 사건처리기, 이벤트처리기
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (chxFloat.Checked == true)//실수
            {
                double opr1 = double.Parse(tbxOPerand1.Text);
                double opr2 = double.Parse(tbxOPerand2.Text);

                double sum = opr1 + opr2;

                lblResult.Text = sum.ToString(); //string
            }
            else
            {
                int opr1 = int.Parse(tbxOPerand1.Text);
                int opr2 = int.Parse(tbxOPerand2.Text);

                int sum = opr1 + opr2;

                lblResult.Text = sum.ToString(); // 1 -> "1"
            }



            //I -> P -> O
        }
    }
}
