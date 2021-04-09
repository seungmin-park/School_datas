using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_1
{
    class Car
    {
        //클래스 (정적) 변수
        public static int HalfHour_Charge = 1000; //30분당 1000원
        public static int TurningTime = 10; //분 ,  회차

        //인스턴스(멤버) 변수
        public string CarNumber;
        public DateTime InTime;
        public DateTime OutTime;

        public int ParkingTime()
        {
            if (this.OutTime == DateTime.MinValue)//DateTime 의 기본값
            {
                // 아직 나가지는 않았는데 지금까지 몇분 추자했는가
                return (int)(DateTime.Now - this.InTime).TotalMinutes;
            }
            else
            {
                //출차함, 출차까지 몇 분 주차했는지
            return (int)(this.OutTime - this.InTime).TotalMinutes;
            }
        }

        public string PrintState()
        {
            int parkingTime = ParkingTime();
            string message;
            if (parkingTime > 0)
            {
                message = string.Format("[{0}] {1}분 주차 ", this.CarNumber, parkingTime);
            }
            else
            {
                message = string.Format("[{0}] 주차중", this.CarNumber);
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
            if(parkingTime <= Car.TurningTime)
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
    }
}
