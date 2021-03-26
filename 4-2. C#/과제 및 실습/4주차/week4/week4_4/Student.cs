using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_4
{
    //class: 자료의 형태를 정의합니다.
    //          (복합데이터구조)
   //             (C언어의 struct)
   //Student라는 타입을 설계...
   //int, double, string --> 기본자료형
   //class로 자료형 --> 사용자정의 자료형
   //학생...표현 (학번,이름,성적3개)
    class Student
    {
        public string Number;
        public string Name;
        public double[] scores = new double[3];
    }
}
