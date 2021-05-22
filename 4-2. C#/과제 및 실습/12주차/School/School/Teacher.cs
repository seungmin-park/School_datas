using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }
        public override string GetInfo()
        {
            return $"{Name}";
        }
    }
}
