using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    //derive:base
    class StudentIndustrialEdu :Student
    {

        const int MAX_REG_SUBJECT = 4;

        private string _company;
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        public StudentIndustrialEdu(string name, string id, string company)
            : base(name, id)
        {
            _company = company;
        }
        public StudentIndustrialEdu(string name, string id, int grade,string company)
            :base(name, id, grade)
        {
            _company = company;
        }

        public new bool RegCourse(string subject)//hiding
        {

            bool result = false;

            if (_subjects == null)
            {
                _subjects = new List<Subject>();
            }
            if (_subjects.Count < MAX_REG_SUBJECT)
            {
                string searchSubject = null;
                foreach (var sub in _subjects)
                {
                    if (sub.Title == subject)
                    {
                        searchSubject = sub.Title;
                        break;
                    }
                }

                if (searchSubject == null)
                {
                    _subjects.Add(new Subject(subject));
                    result = true;
                }
            }
            return result;
        }

        public override bool RegCourseEx(string subject)//overriding
        {

            bool result = false;

            if (_subjects == null)
            {
                _subjects = new List<Subject>();
            }
            if (_subjects.Count < MAX_REG_SUBJECT)
            {
                string searchSubject = null;
                foreach (var sub in _subjects)
                {
                    if (sub.Title == subject)
                    {
                        searchSubject = sub.Title;
                        break;
                    }
                }

                if (searchSubject == null)
                {
                    _subjects.Add(new Subject(subject));
                    result = true;
                }
            }
            return result;
        }
    }
}
