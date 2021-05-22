using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    /// <summary>
    /// 추상클래스
    /// 타입 o 값x
    /// Person p = new Person();
    /// </summary>
    abstract class Person
    {
        protected string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Person(String name)
        {
            this._name = name;
        }

        //추상메소드
        abstract public string GetInfo();
    }
}
