﻿using System;
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
            if(string.IsNullOrEmpty(carNumber) == true)
            {
                Console.WriteLine("차량번호를 제대로 입력해주세요.");
            }
            else
            {
                car.CarNumber = carNumber;
                Console.Write("입고시간 (예:2012/4/3 12:02:03) : ");
                string inTimeput = Console.ReadLine();
                if (string.IsNullOrEmpty(inTimeput) == true)
                {
                    Console.WriteLine("입고시간이 형식이 잘못되었습니다.");
                }
                else
                {
                    string[] test = inTimeput.Split(' ');
                    string[] date = test[0].Split('/');
                    string[] day = test[1].Split(':');
                    Console.Write("출고시간 (예:2012/4/3 12:02:03) : ");
                    string outTimeput = Console.ReadLine();
                    if(string.IsNullOrEmpty(outTimeput) == true)
                    {
                        Console.WriteLine(car.PrintState());
                    }
                }
            }
        }
    }
}
