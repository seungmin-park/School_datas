using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ExternalStudent : Person,IAnalyzable
    {
        private string _code;
        public string Code
        {
            get
            {
                return _code;
            }
        }

        private List<Subject> _subjects;
        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }
        }

        public bool RegCourse(string subject)
        {

            bool result = false;

            if (_subjects == null)
            {
                _subjects = new List<Subject>();
            }
            #region COMMET
            //LINQ
            //if(null == _subject.Where( m => m == subject).FirstOrDefault())
            //{
            //    _subject.Add(subject);
            //    result = true;
            //}
            #endregion

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
            return result;
        }

        public ExternalStudent(string name)
            : base(name)
        {

        }
        public override string GetInfo()
        {
            return $"{_code}--{_name}";
        }

        public bool MinMaxAvg(ref Subject minSubject, ref Subject maxSubject, out double avg)
        {
            avg = 0;

            if (_subjects == null || _subjects.Count <= 0)
            {
                return false;
            }

            double min = Subject.MAX;
            double max = Subject.MIN;
            double sum = 0;

            foreach (var sub in _subjects)
            {
                if (sub.Score < min)
                {
                    min = sub.Score;
                    minSubject = sub;
                }
                else if (sub.Score > max)
                {
                    max = sub.Score;
                    maxSubject = sub;
                }
                sum += sub.Score;
            }

            avg = sum / _subjects.Count;

            return true;
        }
    }
}
