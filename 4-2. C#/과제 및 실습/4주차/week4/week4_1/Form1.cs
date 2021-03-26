using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] scores = new double[10];//배열, 고정 길이
        int scores_index = 0;
        private void btnInput_Click(object sender, EventArgs e)
        {
            //배열의 길이 체크
            if(scores_index >= scores.Length)
            {
                lblResult.Text = "더 이상 입력이 불가능 합니다.";
                return;
            }
            //점수 가져와서 변환
            if (false == double.TryParse(tbxScore.Text, out double score)){
                lblResult.Text = "올바른 형식의 숫자를 넣어주세요";
                return;
            }
            //점수 범위 체크
            if(score < 0.0 || score > 100.0)
            {
                lblResult.Text = "0~100 사이의 점수를 넣어주세요.";
                return;//메소드 종료
            }
            //점수를 저장
            scores[scores_index++] = score;
            //점수 저장 결과여부를 출력....
            lblResult.Text = $"[{scores_index}] {score}점을 입력하였습니다.";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(scores_index == 0)
            {
                lblResult.Text = "조회할 내용이 없습니다.";
                return;
            }

            //평균, 최대값, 최소값
            double avg = 0.0;
            double max = 0;
            double min = 100.0;
            double sum = 0;

            string scores_list = string.Empty;
            for(int i = 0; i <scores_index; i++)
            {
                sum += scores[i];

                if(max < scores[i])
                {
                    max = scores[i];
                }

                if(min > scores[i])
                {
                    min = scores[i];
                }
               
                scores_list += scores_list.Length > 0 ? $", {scores[i]:F2}" : $"{scores[i]:F2}";
            }
            avg = sum / scores_index;
            string message =
                $"현재인원 : {scores_index}명 {Environment.NewLine}" +
                $"전체 점수 : {scores_list} {Environment.NewLine}" +
                $"평균 : {avg:F2} {Environment.NewLine}" +
                $"최고점 : {max:F2} {Environment.NewLine}" +
                $"최저점 : {min:F2} {Environment.NewLine}";

            lblResult.Text = message;
        }
    }
}
