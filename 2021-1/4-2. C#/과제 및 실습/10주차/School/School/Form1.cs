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

        Student _studuentRegCourse = null;
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

            _studuentRegCourse = null;
            foreach(var stu in _students)
            {
                if(stu.Id == tbxReCourseSearchId.Text)
                {
                    _studuentRegCourse = stu;
                    break;
                }
                
            }
            if(_studuentRegCourse == null)
            {
                lblRegCourseId.Text = string.Empty;
                lblRegCourseName.Text = string.Empty;
                lbxRegCourse.Items.Clear();

                MessageBox.Show("해당 학생을 찾을 수 없습니다.");
            }
            else
            {
                lblRegCourseId.Text = _studuentRegCourse.Id;
                lblRegCourseName.Text = _studuentRegCourse.Name;
                lbxRegCourse.Items.Clear();
                foreach(var sub in _studuentRegCourse.Subject)
                {
                    lbxRegCourse.Items.Add(sub);
                }
            }
        }

        private void btnRegCourseHiding_Click(object sender, EventArgs e)
        {
            if(_studuentRegCourse != null)
            {
                if (_studuentRegCourse.RegCourse(tbxRegCourseName.Text))//hiding
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
            if (_studuentRegCourse != null)
            {
                if (_studuentRegCourse.RegCourseEx(tbxRegCourseName.Text))//overriding
                {
                    lbxRegCourse.Items.Add(tbxRegCourseName.Text);
                }
                else
                {
                    MessageBox.Show("등록실패");
                }
            }
        }
    }
}
