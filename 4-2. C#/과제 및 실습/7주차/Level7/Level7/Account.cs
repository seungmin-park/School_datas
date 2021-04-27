using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    class Account
    {
        private static int _maxBalance = 10000000;// static 클래스 변수
        private string _owner;
        public string Owner //프로퍼티
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        private string _number;
        private int _balance;

        //public Account() //기본 생성자
        //{
        //}

        public Account(string number, string name, int money)//사용자 정의 생성자
        {
            this._number = number;
            this._owner = name;
            this._balance = money;
        }

        public Account(string number, string name)//사용자 정의 생성자
        {
            this._number = number;
            this._owner = name;
            //this._balance = 0; 인스턴스 변수는 기본적으로 초기화됨
        }

        int[,] abc = new int[0,0];

        public bool Deposit(int amount)//amount 는 지역변수이자 매개변수
        {
            if (this._balance + amount > Account._maxBalance)
            {
                return false;
            }
            else
            {
                this._balance += amount;
                return true;
            }
        }

        public bool WithDraw(int amount)
        {
            if(this._balance - amount < 0)
            {
                return false;
            }
            else
            {
                this._balance -= amount;
                return true;
            }
        }

        public StringBuilder Info()
        {
            StringBuilder builder = new StringBuilder();
            //문자열을 여러개 조합할때 +연산자 대신 스트링 빌더 사용하기 + 연산자는 힙영역이 계속 증식
            builder.Append("번호 : ").Append(this._number);
            builder.Append(Environment.NewLine);
            builder.Append("이름 : ").Append(this._owner);
            builder.Append(Environment.NewLine);
            builder.Append("잔액 : ").Append(this._balance);

            return builder;
        }
    }
}
