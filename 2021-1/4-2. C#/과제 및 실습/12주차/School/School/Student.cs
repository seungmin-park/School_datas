using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
        :Person,IAnalyzable
    {
        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
        }

        //private string _name;//이름
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //}

        private int _grade;//학년
        public int Grade
        {
            get
            {
                return _grade;
            }

            set
            {
                _grade = value;
            }
        }
        //protected - derived(자식에게 파생가능)
        //private - only me(자식에게 상속 X) 
        protected List<Subject> _subjects;//수강과목
        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }
        }

        public Student(string name, string id)
            :base(name)
        {
            _name = name;
            _id = id;
            _grade = 1;
            _subjects = new List<Subject>();
        }

        public Student(string name, string id, int grade)
            : this(name,id)
        {
            Grade = grade;
        }

        
        public bool RegCourse(string subject)
        {

            bool result = false;

            if(_subjects == null)
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
            foreach(var sub in _subjects)
            {
                if(sub.Title == subject)
                {
                    searchSubject = sub.Title;
                    break;
                }
            }

            if(searchSubject == null)
            {
                _subjects.Add(new Subject(subject));
                result = true;
            }
            return result;
        }

        public virtual bool RegCourseEx(string subject)
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

        public override string GetInfo()
        {
            return $"{_id}--{_name}--{_grade}";
        }

        public bool MinMaxAvg(ref Subject minSubject, ref Subject maxSubject, out double avg)
        {
            avg = 0;

            if(_subjects == null || _subjects.Count <= 0)
            {
                return false;
            }

            double min = Subject.MAX;
            double max = Subject.MIN;
            double sum = 0;
            
            foreach(var sub in _subjects)
            {
                if(sub.Score < min)
                {
                    min = sub.Score;
                    minSubject = sub;
                }
                else if(sub.Score > max)
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
