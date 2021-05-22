using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        const int MAX_GRADE = 4;
        List<Student> _students;//Studnet(base), StundetIndustrialEdu(derived)

        Student _studentRegCourse = null;
        Student _studentAttend = null;
        Student _studentScore = null;
        Student _studentView = null;
        public Form1()
        {
            InitializeComponent();
            
            _students = new List<Student>();
            for(int i = 1; i <= MAX_GRADE; i++)
            {
                cbxEntranceGrade.Items.Add(i.ToString());
            }

            cbxEntranceGrade.SelectedIndex = 0;
        }

        private void chkIndustrialEdu_CheckedChanged(object sender, EventArgs e)
        {
            pnlEntranceCompany.Visible = chkIndustrialEdu.Checked;
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            //빈 칸 여부판단
            if(string.IsNullOrEmpty(tbxEntranceName.Text) || 
                (chkIndustrialEdu.Checked && string.IsNullOrEmpty(tbxEntranceCompany.Text))){
                MessageBox.Show("값을 넣어주세요");
                return;
            }
            string temp_str = null;
            int temp_int = 0;

            int grade = 1;
            //형변환여부판단
            int.TryParse(cbxEntranceGrade.SelectedItem.ToString(), out grade);

            int year = DateTime.Now.Year - (grade - 1);
            string id = string.Empty;
            if (_students != null && _students.Count > 0)
            {
                temp_str = year.ToString("0000");
                temp_str = _students.Where(m => m.Id.StartsWith(temp_str))
                    .OrderByDescending(m => m.Id)
                    .Select(m => m.Id)
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(temp_str))
                {
                    //해당 학번대의 학생이 아무도 없는 경우
                    id = $"{year:0000}0001";
                }
                else
                {
                    //20210002 -> 20210003
                    int.TryParse(temp_str.Substring(4, 4), out temp_int);
                    id = id = $"{year:0000}{temp_int + 1:0000}";
                }
            }
            else
            {
                //학생이 아무도없음
                id = $"{year:0000}0001";
            }
            Student student = null;
            if (chkIndustrialEdu.Checked)//산학
            {
                student = new StudentIndustrialEdu(tbxEntranceName.Text, id, grade, tbxEntranceCompany.Text);
            }
            else
            {
                student = new Student(tbxEntranceName.Text, id, grade);
            }

            _students.Add(student);

            lblEntranceResult.Text = $"등록학생의 정보입니다. " +
                $"\r\n학번 : {student.Id} \r\n" +
                $"이름 : {student.Name} \r\n" +
                $"학년 : {student.Grade}\r\n";
            //Type 1
            //if(student is StudentIndustrialEdu)
            //{
            //    temp_str = ((StudentIndustrialEdu)student).Company;
            //    lblEntranceResult.Text += $"[산학과정] 소속회사{temp_str}";
            //}

            //Type 2
            StudentIndustrialEdu studentIE = student as StudentIndustrialEdu;
            if(studentIE != null)
            {
                lblEntranceResult.Text += $"[산학과정] 소속회사 : {studentIE.Company}";
            }
        }

        private void btnRegCourseSearch_Click(object sender, EventArgs e)
        {
            if(_students == null || _students.Count < 0)
            {
                MessageBox.Show("검색할 학생이 없습니다.");
                return;
            }

            _studentRegCourse = null;
            foreach(var stu in _students)
            {
                if(stu.Id == tbxReCourseSearchId.Text)
                {
                    _studentRegCourse = stu;
                    break;
                }
                
            }
            if(_studentRegCourse == null)
            {
                lblRegCourseId.Text = string.Empty;
                lblRegCourseName.Text = string.Empty;
                lbxRegCourse.Items.Clear();

                MessageBox.Show("해당 학생을 찾을 수 없습니다.");
            }
            else
            {
                lblRegCourseId.Text = _studentRegCourse.Id;
                lblRegCourseName.Text = _studentRegCourse.Name;
                lbxRegCourse.Items.Clear();
                foreach(var sub in _studentRegCourse.Subjects)
                {
                    lbxRegCourse.Items.Add(sub);
                }
            }
        }

        private void btnRegCourseHiding_Click(object sender, EventArgs e)
        {
            if(_studentRegCourse != null)
            {
                if (_studentRegCourse.RegCourse(tbxRegCourseName.Text))//hiding
                {
                    lbxRegCourse.Items.Add(tbxRegCourseName.Text);
                }
                else
                {
                    MessageBox.Show("등록실패");
                }
            }
        }

        private void btnRegCourseOverriding_Click(object sender, EventArgs e)
        {
            if (_studentRegCourse != null)
            {
                if (_studentRegCourse.RegCourseEx(tbxRegCourseName.Text))//overriding
                {
                    lbxRegCourse.Items.Add(tbxRegCourseName.Text);
                }
                else
                {
                    MessageBox.Show("등록실패");
                }
            }
        }

        private void btnAttendSearch_Click(object sender, EventArgs e)
        {
            if (_students == null || _students.Count < 0)
            {
                MessageBox.Show("검색할 학생이 없습니다.");
                return;
            }

            _studentAttend = null;
            foreach (var stu in _students)
            {
                if (stu.Id == tbxReCourseSearchId.Text)
                {
                    _studentAttend = stu;
                    break;
                }

            }
            if (_studentAttend == null)
            {
                lblAttendId.Text = string.Empty;
                lblAttendName.Text = string.Empty;
                dgvAttend.Rows.Clear();

                MessageBox.Show("해당 학생을 찾을 수 없습니다.");
            }
            else
            {
                lblAttendId.Text = _studentAttend.Id;
                lblAttendName.Text = _studentAttend.Name;

                SetAttendState();
            }
        }

        private void SetAttendState()
        {
            dgvAttend.Rows.Clear();

            foreach(Subject sub in _studentAttend.Subjects)
            {
                int index = dgvAttend.Rows.Add();
                dgvAttend.Rows[index].Cells[0].Value = sub.Title;

                for(int i = 1; i <= Subject.WEEK; i++)
                {
                    dgvAttend.Rows[index].Cells[i].Value = GetStringState(sub, i);
                }
            }
        }

        private string GetStringState(Subject sub, int week)
        {
            if(week < 1 || week > Subject.WEEK)
            {
                return string.Empty;
            }

            ATTEND_TYPE state = sub[week];
            string display = string.Empty;

            switch (state)
            {
                case ATTEND_TYPE.ABSENCE:
                    display = "결";
                    break;
                case ATTEND_TYPE.ATTEND:
                    display = "출";
                    break;
                case ATTEND_TYPE.LATE:
                    display = "지";
                    break;
            }

            return display;
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if(_studentAttend == null ||
                dgvAttend.SelectedCells.Count != 1||
                dgvAttend.SelectedCells[0].ColumnIndex < 1)
            {
                return;
            }

            int week = dgvAttend.SelectedCells[0].ColumnIndex;
            int sub_index = dgvAttend.SelectedCells[0].RowIndex;

            Subject subject = _studentAttend.Subjects[sub_index];
            ATTEND_TYPE state = ATTEND_TYPE.EMPTY;
            if(button == btnAttend1)
            {
                state = ATTEND_TYPE.EMPTY;
            }
            else if(button == btnAttend2)
            {
                state = ATTEND_TYPE.ATTEND;
            }
            else if (button == btnAttend3)
            {
                state = ATTEND_TYPE.LATE;
            }
            else if (button == btnAttend4)
            {
                state = ATTEND_TYPE.ABSENCE;
            }
            else
            {
                return;
            }

            subject[week] = state;
            dgvAttend.SelectedCells[0].Value = GetStringState(subject, week);

            //dgvAttend.SelectedCells[0].Value = string.Empty;
        }

        private void btnScoreSearch_Click(object sender, EventArgs e)
        {
            if (_students == null || _students.Count < 0)
            {
                MessageBox.Show("검색할 학생이 없습니다.");
                return;
            }

            _studentScore = null;
            foreach (var stu in _students)
            {
                if (stu.Id == tbxReCourseSearchId.Text)
                {
                    _studentScore = stu;
                    break;
                }

            }
            if (_studentScore == null)
            {
                lblScoreId.Text = string.Empty;
                lblScoreName.Text = string.Empty;
                dgvScore.Rows.Clear();

                MessageBox.Show("해당 학생을 찾을 수 없습니다.");
            }
            else
            {
                lblScoreId.Text = _studentScore.Id;
                lblScoreName.Text = _studentScore.Name;

                SetScoreState();
            }
        }

        private void SetScoreState()
        {
            dgvScore.Rows.Clear();
            foreach(Subject sub in _studentScore.Subjects)
            {
                int index = dgvScore.Rows.Add();
                dgvScore.Rows[index].Cells[0].Value = sub.Title;
                dgvScore.Rows[index].Cells[0].Value = sub.Score.ToString("F1");
            }
        }

        private void btnScoreSave_Click(object sender, EventArgs e)
        {
            if(_studentScore == null ||
                dgvScore.Rows.Count <= 0)
            {
                return;
            }

            for(int i = 0; i < dgvScore.Rows.Count; i++)
            {
                if(double.TryParse(dgvScore.Rows[i].Cells[1].Value.ToString(), out double score))
                {
                    _studentScore.Subjects[i].Score = score;
                }
            }

            //refresh
            SetScoreState();
        }

        private void btnViewSearch_Click(object sender, EventArgs e)
        {
            if (_students == null || _students.Count < 0)
            {
                MessageBox.Show("검색할 학생이 없습니다.");
                return;
            }

            _studentView = null;
            foreach (var stu in _students)
            {
                if (stu.Id == tbxReCourseSearchId.Text)
                {
                    _studentView = stu;
                    break;
                }

            }
            if (_studentView == null)
            {
                lblViewId.Text = string.Empty;
                lblViewName.Text = string.Empty;
                dgvView.Rows.Clear();
                lblViewAvg.Text = string.Empty;
                lblViewMax.Text = string.Empty;
                lblViewMin.Text = string.Empty;

                MessageBox.Show("해당 학생을 찾을 수 없습니다.");
            }
            else
            {
                lblViewId.Text = _studentView.Id;
                lblViewName.Text = _studentView.Name;

                SetViewState();
            }
        }

        private void SetViewState()
        {
            dgvView.Rows.Clear();

            foreach(Subject sub in _studentView.Subjects)
            {
                int index = dgvView.Rows.Add();

                dgvView.Rows[index].Cells[0].Value = sub.Title;
                dgvView.Rows[index].Cells[1].Value = sub.Score.ToString("F1");

                //int empty, attend, absence, late;
                sub.AttendState(out int empty, out int attend, out int absence, out int late);

                dgvView.Rows[index].Cells[2].Value = attend;
                dgvView.Rows[index].Cells[3].Value = late;
                dgvView.Rows[index].Cells[4].Value = absence;
            }

            Subject maxSudject = null;
            Subject minSudject = null;
            double avg = 0.0;
            if (_studentAttend.MinMaxAvg(ref minSudject, ref maxSudject, out avg))
            {
                lblViewAvg.Text = avg.ToString("F1");
                lblViewMax.Text = maxSudject.Score.ToString("F1");
                lblViewMin.Text = minSudject.Score.ToString("F1");
            }
            else
            {
                lblViewAvg.Text = string.Empty;
                lblViewMax.Text = string.Empty;
                lblViewMin.Text = string.Empty;
            }
        }
    }
}
