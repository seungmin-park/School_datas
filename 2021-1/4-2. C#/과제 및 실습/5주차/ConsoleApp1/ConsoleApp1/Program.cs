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

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[3];
            car[0] = new Car();
            car[0].CarNumber = "123라4567";
            car[0].InTime = new DateTime(2021, 4, 2, 9, 12, 10);
            car[0].OutTime = DateTime.Now;

            var parkingtime = (int)(car[0].OutTime - car[0].InTime).TotalMinutes;

            if (parkingtime > 0)
            {
                Console.WriteLine("[{0}] {1}분 주차", car[0].CarNumber, parkingtime);
            }
            else
            {
                Console.WriteLine("[{0}] 주차중", car[0].CarNumber);
            }

            #region TEST1
            //string carNumber;
            //DateTime inTime;
            //DateTime outTime;
            #endregion

            #region TEST2
            //string carNumber1;
            //DateTime inTime1;
            //DateTime outTime1;
            //string carNumber2;
            //DateTime inTime2;
            //DateTime outTime2;

            //string carNumber3;
            //DateTime inTime3;
            //DateTime outTime3;
            #endregion

            #region TEST3
            /*
            string[] carNumber = new string[3];
            DateTime[] inTime = new DateTime[3];
            DateTime[] outTime = new DateTime[3];

            carNumber[0] = "123라4567";
            inTime[0] = new DateTime(2021,4,2,9,12,10);
            outTime[0] = DateTime.Now;

            var parkingtime = (int) (outTime[0] - inTime[0]).TotalMinutes;

            if(parkingtime > 0)
            {
                Console.WriteLine("[{0}] {1}분 주차",carNumber[0],parkingtime);
            }
            else
            {
                Console.WriteLine("[{0}] 주차중", carNumber[0]);
            }
            */
            #endregion
        }
    }
}
