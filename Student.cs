using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Interfaces_and_Ienumerable
{
    internal class Student
    {
        string _name;

        public Student(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public override string ToString() 
        {
            return $"{_name}";
        }

    }//class
}//namespace
