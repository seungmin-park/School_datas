using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Subject
    {
        const double MAX = 1000;
        const double MIN = 0.0;
        public string Title // 과목명
        {
            get; //자동구현 프로퍼티
            set;
        }

        private double? _score; //점수
        public double? Score
        {
            get
            {
                return _score;//항상더블타입을 반환 한다는 보장이 없음 프로퍼티도 nullable
            }
            set
            {
                if(value == null || value < MIN || value > MAX)//value == null 테스트 해보기
                {
                    _score = null;
                }
                else
                {
                _score = value;
                }
            }
        }

        public Subject(string title)
        {
            Title = title;
            Score = null;
        }
    }
    class RegSubjectList
    {
        List<Subject> subjects = new List<Subject>();

        public Subject this[int index]
        {
            get
            {
                if(index < subjects.Count && index >= 0)
                {
                return subjects[index];
                }
                else
                {
                    return null;
                }
            }
        }

        public int Count// 프로퍼티가 private 랑 세트를 이룰 필요는 없다.
        {
            get
            {
                return subjects.Count;
            }
        }

        public bool RegSubject(string title)
        {
            try// RegSubjectList클래스 리스트 초기화하지 않았을때 List<Subject> subjects ;
            {
                subjects.Add(new Subject(title));
                return true;
            }
            catch(Exception ex)
            {
                throw ex; // 반환타입 bool return false 없어도 에러 안남 -> 어차피 메소드 사망,여기서 에러처리 하지 않을때 호출메소드로 에러 던짐
                //Console.WriteLine(ex.Message);
                //return false;
            }
        }

        public bool SetScore(string title, double score)
        {
            bool result  = false;

            for(int i  = 0; i < subjects.Count; i++)
            {
                if(subjects[i].Title == title)
                {
                    subjects[i].Score = score;
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool Avg(out double value)
        {
            bool result = false;
            value = 0.0;

            double sum = 0;
            int count = 0;

            foreach(var sub in subjects)
            {
                if(sub.Score != null)
                {
                    sum += (double)sub.Score;//(double) 없을 시 sub.Score double?타입이기 때문에 에러 if문에서 처리했기때문에 타입 강제 변환
                    count++;
                }
            }

            if(count > 0)
            {
                value = sum / count;
                result = true;
            }

            return result;
        }
    }
    class Student
    {
        public string Name;
        public RegSubjectList RegSubjects = new RegSubjectList();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "박승민";
            double avg = 0.0;

            if(student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균 : " + avg);
            }
            else
            {
                Console.WriteLine("평균없음"); // 수강 신청없을시 평균없음 출력
            }

            student.RegSubjects.RegSubject("영어");
            student.RegSubjects.RegSubject("국어");
            student.RegSubjects.RegSubject("수학");

            if (student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균 : " + avg);
            }
            else
            {
                Console.WriteLine("평균없음");//과목은 등록하였으나 점수를 추가하지않음
            }

            student.RegSubjects.SetScore("국어", 100);
            student.RegSubjects.SetScore("영어", 50);

            if (student.RegSubjects.Avg(out avg))
            {
                Console.WriteLine("평균 : " + avg);//과목 3개 등록하였으나 점수까지 등록한 과목은 2개 (100+50) /2 ->점수까지 등록된 과목수
            }
            else
            {
                Console.WriteLine("평균없음");
            }

            //단 foreach는 사용할 수 없다.
            for(int i = 0; i < student.RegSubjects.Count; i++)
            {
                Subject sub = student.RegSubjects[i];
                Console.WriteLine($"{sub.Title}-->{sub.Score?? 0}");//널병합 연산자 nullable 타입이라 사용가능 null일 경우 0
            }

            string dir = "c:\\test";
            if (!Directory.Exists(dir))//디렉토리 존재여부
            {
                Directory.CreateDirectory(dir);//디렉토리 생성
            }

            string file = dir + "\\test.txt";
            if (File.Exists(file))//파일 존재여부
            {
                File.Delete(file);//파일삭제
            }
            else
            {
                File.Create(file);//파일생성
            }
        }
    }
}
