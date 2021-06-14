using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_4
{
    class Utility
    {
        //Form1의 인스턴스 변수
        //Metod Overloading
        //메소드 이름은동일
        //메소드 매개변수의 갯수나 타입만 다르면 됨
        public static int MakeTestTime()
        {
            Random rand = new Random();
            return rand.Next(-70, 0);
        }

        public static int MakeTestTime(int min)
        {
            Random rand = new Random();
            return rand.Next(min, 0);
        }

        public static int MakeTestTime(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(-min, max);
        }
    }
}
