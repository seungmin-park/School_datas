using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string CarNumber;
        public DateTime InTime;
        public DateTime OutTime;

        public int ParkingTime()
        {
            return (int)(this.OutTime - this.InTime).TotalMinutes;
        }

        public string PrintState()
        {
            int parkingTime = ParkingTime();
            string message;
            if(parkingTime > 0)
            {
                message = string.Format("[{0}] {1}분 주차 ", this.CarNumber, parkingTime);
            }
            else
            {
                message = string.Format("[{0}] 주차중", this.CarNumber);
            }

            return message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            // 코드 완성
            Console.WriteLine(car.PrintState());
        }
    }
}
