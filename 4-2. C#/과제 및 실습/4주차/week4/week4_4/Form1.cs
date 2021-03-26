using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currIndex = 0;
        Student[] students = new Student[10];//기본값 : null
        private void btnInput_Click(object sender, EventArgs e)
        {
            //입력
            if (currIndex >= students.GetLength(0))
            {
                lblResult.Text = " 더 이상 입력할 수 없습니다.";
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxNumber.Text) || string.IsNullOrWhiteSpace(tbxName.Text))
            {
                lblResult.Text = "학번/이름을 반드시 넣어주세요";
                return;
            }

            if (false == double.TryParse(tbxKor.Text, out double scoreKor)
            || false == double.TryParse(tbxEng.Text, out double scoreEng)
            || false == double.TryParse(tbxMat.Text, out double scoreMat))
            {
                lblResult.Text = "정확한 형식의 값을 넣어주세요";
                return;
            }
            if (scoreKor < 0.0 || scoreKor > 100.0
                || scoreEng < 0.0 || scoreEng > 100.0
                || scoreMat < 0.0 || scoreMat > 100.0)
            {
                lblResult.Text = "0~100사이의 값을 입력하세요";
                return;
            }

            for (int i = 0; i < currIndex; i++)
            {
                if (students[i].Number == tbxNumber.Text.Trim())
                {
                    lblResult.Text = "동일한 학번은 사용할 수 없습니다.";
                    return;
                }
            }

            //Student 자료형을 생성하고
            //원하는 값으로 설정함
            Student stu = new Student();//생성자       className();

            stu.Number = tbxNumber.Text.Trim();
            stu.Name = tbxName.Text.Trim();
            stu.scores[0] = scoreKor;
            stu.scores[1] = scoreEng;
            stu.scores[2] = scoreMat;
            students[currIndex] = stu;

            lblResult.Text = $"[{stu.Number}/{stu.Name}] 국어 : {scoreKor} 영어 : {scoreEng} 영어 : {scoreMat}";
            currIndex++;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (currIndex == 0)
            {
                lblResult.Text = "조회할 내용이 없습니다.";
                return;
            }

            string scores_list = string.Empty;
            double sum = 0, avg = 0;
            double max = 0, min = 100.0;

            for (int i = 0; i < currIndex; i++)//학생, 입력순서
            {
                #region 학생 한명의 전체 성적
                double sub_sum = 0.0, sub_avg = 0.0;
                string sub_scores_list = string.Empty;
                for (int j = 0; j < students[i].scores.Length; j++)//0~2, 입력순서
                {
                    sub_sum += students[i].scores[j];
                    sub_scores_list += sub_scores_list.Length > 0 ? $", {students[i].scores[j]}" : $"[{students[i].Number}/{students[i].Name}] {students[i].scores[j]}";
                }
                sub_avg = sub_sum / students[i].scores.Length;
                sub_scores_list += $" => 평균 : {sub_avg,4:F2}";
                #endregion
                sum += sub_avg;

                if (max < sub_avg) { max = sub_avg; }
                if (min > sub_avg) { min = sub_avg; }

                scores_list += sub_scores_list + Environment.NewLine;
            }

            avg = sum / currIndex;

            string message =
                 $"현재인원 : {currIndex}명 {Environment.NewLine}" +
                 $"전체 점수 : {Environment.NewLine}{scores_list}" +
                 $"평균 : {avg:F2} {Environment.NewLine}" +
                 $"최고점 : {max:F2} {Environment.NewLine}" +
                 $"최저점 : {min:F2} {Environment.NewLine}";

            lblResult.Text = message;
        }
    }
}
