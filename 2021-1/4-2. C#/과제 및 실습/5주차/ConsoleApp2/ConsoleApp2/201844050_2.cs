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
            Console.Write("차량번호:");
            string carNumber = Console.ReadLine();
            if(string.IsNullOrEmpty(carNumber) == true) //차량번호 입력되었는지 판단
            {
                Console.WriteLine("차량번호를 제대로 입력해주세요.");
            }
            else
            {
                //입고시간 입력
                car.CarNumber = carNumber;
                Console.Write("입고시간 (예:2012/4/3 12:02:03) : ");
                string inTimeput = Console.ReadLine();
                if (string.IsNullOrEmpty(inTimeput) == true)//입고시간 입력되었는지 판단
                {
                    Console.WriteLine("입고시간이 형식이 잘못되었습니다.");
                }
                else
                {
                    string[] inSplit = inTimeput.Split(' ');
                    string[] inDate = inSplit[0].Split('/');
                    string[] inDay = inSplit[1].Split(':');
                    if(inSplit.Length != 2 || inDate.Length != 3 || inDay.Length != 3)//입고시간의 년/월/일 시/분/초 확인
                    {
                        Console.WriteLine("입고시간이 형식이 잘못되었습니다.");
                    }
                    else
                    {
                        Console.Write("출고시간 (예:2012/4/3 12:02:03) : ");
                        string outTimeput = Console.ReadLine();
                        if (string.IsNullOrEmpty(outTimeput) == false)//출고시간 입력되었는지 판단
                        {
                            string[] outSplit = outTimeput.Split(' ');
                            string[] outDate = outSplit[0].Split('/');
                            string[] outDay = outSplit[1].Split(':');
                            if (outSplit.Length != 2 || outDate.Length != 3 || outDay.Length != 3)
                            {
                                Console.WriteLine("출고시간이 형식이 잘못되었습니다.");
                            }
                            else
                            {
                                car.InTime = DateTime.ParseExact(inTimeput, "yyyy/M/d H:m:s", null);
                                car.OutTime = DateTime.ParseExact(outTimeput, "yyyy/M/d H:m:s", null);
                            }
                        }
                        Console.WriteLine(car.PrintState());
                    }
                }
            }
        }
    }
}
