using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Interfaces_and_Ienumerable
{
    internal class SchoolClass : IEnumerable
    {
        List<Student> _classRoster;

        public SchoolClass()
        { 
            _classRoster = new List<Student>();

            _classRoster.Add(new Student("Ethan"));
            _classRoster.Add(new Student("Olivia"));
            _classRoster.Add(new Student("Liam"));
            _classRoster.Add(new Student("Emma"));
            _classRoster.Add(new Student("Noah"));
            _classRoster.Add(new Student("Sophia"));
            _classRoster.Add(new Student("Lucas"));
            _classRoster.Add(new Student("Ava"));
            _classRoster.Add(new Student("Benjamin"));
            _classRoster.Add(new Student("Isabella"));
            _classRoster.Add(new Student("Mason"));
            _classRoster.Add(new Student("Mia"));
            _classRoster.Add(new Student("Oliver"));
            _classRoster.Add(new Student("Austin"));
            _classRoster.Add(new Student("Elijah"));
            _classRoster.Add(new Student("Harper"));
            _classRoster.Add(new Student("William"));
            _classRoster.Add(new Student("Amelia"));
            _classRoster.Add(new Student("James"));
            _classRoster.Add(new Student("Abigail"));
        }

        public IEnumerator GetEnumerator()
        {
           return new SchoolClassEnumerator(ref _classRoster);
        }

        private class SchoolClassEnumerator : IEnumerator
        {
            int index = -1;
            List<Student> _classRoster;

            public SchoolClassEnumerator(ref List<Student> classRoster)
            {
                _classRoster = classRoster;
            }

            public object Current => _classRoster[index];

            public bool MoveNext()
            {
                index++;
                if (index >= _classRoster.Count)
                { 
                    return false; 
                }
                else 
                { 
                    return true;
                }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }//class
}//namespace
