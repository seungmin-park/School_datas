using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_4
{
    class Car
    {
        //클래스 (정적) 변수
        public static int HalfHour_Charge = 1000; //30분당 1000원
        public static int TurningTime = 10; //분 ,  회차

        //인스턴스(멤버) 변수
        private string _carNumber;
        public string CarNumber// 읽기 전용 PROPERTY
        {
           get {
                return this._carNumber;
            }
            //set {
            //
            //}
        }
        private DateTime _inTime;
        public DateTime InTime
        {
            get
            {
                return this._inTime;
            }
        }
        private DateTime _outTime;
        public DateTime OutTime
        {
            set
            {
                this._outTime = value;
            }
        }

        //생성자가 하나도 없다면, 컴파일러가  기본 생성자를 강제로 만듬
        //public Car()//기본생성자
        //{
        //}

        //초기화 작업할 때
        public Car(string number)
        {
            this._carNumber = number;
            //인스턴스 메소드
            //Utility ut = new Utility();
            //this._inTime = ut.MakeTestTime();
            
            //클래스 메소드
            this._inTime = DateTime.Now.AddMinutes(Utility.MakeTestTime());
        }
        public int ParkingTime()
        {
            if (this._outTime == DateTime.MinValue)//DateTime 의 기본값
            {
                // 아직 나가지는 않았는데 지금까지 몇분 추자했는가
                return (int)(DateTime.Now - this._inTime).TotalMinutes;
            }
            else
            {
                //출차함, 출차까지 몇 분 주차했는지
                return (int)(this._outTime - this._inTime).TotalMinutes;
            }
        }

        public string PrintState()
        {
            int parkingTime = ParkingTime();
            string message;
            if (parkingTime > 0)
            {
                message = string.Format("[{0}] {1}분 주차 ", this._carNumber, parkingTime);
            }
            else
            {
                message = string.Format("[{0}] 주차중", this._carNumber);
            }

            return message;
        }

        public int CalcParkingCharge()
        {
            //주차시간 계산
            //주차시간 회차 시간 내인지 검사
            //  회차시간내면, 요금 0원 처리
            // 주차시간을 30분 단위 계산 요금을 곱해서
            // 요금 계산한 것을 반환

            int parkingTime = ParkingTime();
            if (parkingTime <= Car.TurningTime)
            {
                return 0;
            }
            else
            {
                var halfHour = parkingTime / 30;
                var reminderHour = parkingTime % 30;
                var totalChrage = (halfHour * Car.HalfHour_Charge)
                    + (reminderHour > 0 ? Car.HalfHour_Charge : 0);

                return totalChrage;
            }
        }

        public void GoOut()
        {
            this._outTime = DateTime.Now;
        }
    }
}
