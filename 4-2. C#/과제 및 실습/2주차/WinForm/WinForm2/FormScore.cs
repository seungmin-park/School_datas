using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        //이벤트 핸들러, 이벤트 처리기 (메소드)
        private void btnCal_Click(object sender, EventArgs e)
        {
            //과목 점수를 가져온다
            //double <= string
            double kor = double.Parse(tbxKor.Text);
            double eng = double.Parse(tbxEng.Text);
            double mat = double.Parse(tbxMat.Text);

            //과목점수를 가지고 계산한다.
            double sum = kor + eng + mat;
            double avg = sum / 3;

            //계산한 결과를 출력한다
            //레이블 Text = 숫자.Tostring()
            lblAvg.Text = avg.ToString("F3");
            lblSum.Text = sum.ToString("0.000");

            if(avg < 60)
            {
                //불합격
                lblResult.Text = "불합격(F)";
            }
            else
            {
                //합격
                lblResult.Text = "합격";
                if(avg >= 90)
                {
                    lblResult.Text += "(A)";
                }else if(avg >= 80)
                {
                    lblResult.Text += "(B)";
                }
                else if(avg >= 70)
                {
                    lblResult.Text += "(C)";
                }
                else
                {
                    lblResult.Text += "D";
                }
            }
        }
    }
}
