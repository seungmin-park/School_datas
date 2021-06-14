using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    class Book
    {
        //총 권수 - 클래스 변수
        static int _bookCount;
        //책이름
        string _name;
        //책번호
        string _id;
        //대출자목록
        List<string> _rentalUsers;
        //마지막 대출일자
        DateTime _rentalDate;
        private const int RENTAL_MAX_COUNT = 100; //cosnt는 애초에 static

        public Book(string name, string id)
            //: this(id) //this 생성자 넘모 어렵구
        {
            this.Name = name;
            this._id = id;
            _bookCount++;
        }

        public Book(string id)
            :this(id,"UNKNOWN")
        {
            //this._id = id;
            //this.Name = "UNKNOWN";
            //_bookCount++;
        }
    public string Name
        {
            get
            {
                //if(_name == null || _name == "")
                //if (string.IsNullOrEmpty(_name))
                //{
                //    return "제목없음";
                //}
                //else
                //{
                //return _name;
                //}
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                this._name = "제목없음";
                }
                else
                {
                    this._name = value;
                }
            }
        }

        public bool DoReturn() //책 반납실행;
        {
            bool result = false;
            if(_rentalUsers.Count < RENTAL_MAX_COUNT && _rentalDate != DateTime.MinValue)
            {
                this._rentalDate = DateTime.MinValue;
                result = true;
            }
                return result;
        }

        public bool DoRental(string name) //책 대여 수행
        {
            if(_rentalDate != DateTime.MinValue)
            {
            _rentalUsers.Add(name);
            _rentalDate = DateTime.Now;
            return true;
            }
            return false;
        }

        public bool IsRental(string name)
        {
            bool result = false;
            foreach(var n in _rentalUsers)
            {
                if(n == name)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public int GetTotalRentalCount()
        {
            return _rentalUsers.Count;
        }
    }
}
