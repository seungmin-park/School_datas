using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    /// <summary>
    /// 열거형
    /// 출석 타입 정수형 = 이름
    /// </summary>
    enum ATTEND_TYPE
    {
        EMPTY=0,
        ATTEND=1,
        LATE=2,
        ABSENCE=3,
    }
    class Subject
    {
        public const double MAX = 100.0;
        public const double MIN = 0.0;
        public const int WEEK = 8;

        string _title;
        public string Title
        {
            get
            {
                return _title;
            }
        }
        double _score;
        public double Score
        {
            get
            {
                return _score;
            }
            set
            {
                if(MIN <= value && value <= MAX)
                {
                    _score = value;
                }
            }
        }
        ATTEND_TYPE[] _attendanceBook;

        //활용예
        //Subject sub = new Subject("제목");
        //sub[0] = ATTEND_TYPE.EMPTY;

        public ATTEND_TYPE this[int week]
        {
            get
            {
                if (week >= 1 || week <= WEEK)
                {
                    return _attendanceBook[week - 1];
                }
                else
                {
                    return ATTEND_TYPE.EMPTY;
                }
            }
            set
            {
                if(week >= 1 || week <= WEEK)
                {
                _attendanceBook[week - 1] = value;
                }
                
            }
        }

        public void AttendState(out int empty, out int attend
            ,out int absence, out int late)
        {
            empty = 0;
            attend = 0;
            absence = 0;
            late = 0;

            for(int i = 1; i < Subject.WEEK; i++)
            {
                ATTEND_TYPE state = this[i]; //인데서를 이용해서 값을 가져오고 있음
                if(state == ATTEND_TYPE.ATTEND)
                {
                    attend++;
                }
                else if(state == ATTEND_TYPE.ABSENCE)
                {
                    absence++;
                }
                else if(state  == ATTEND_TYPE.LATE)
                {
                    late++;
                }
                else
                {
                    empty++;
                }
            }
        }

        public Subject(string title)
        {
            this._title = title;
            _score = MIN;
            _attendanceBook = new ATTEND_TYPE[WEEK];
        }
    }
}
