using IndexerLesson.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson
{
    internal class StudentList
    {
        public StudentList()
        {

        }

        public StudentList(Student[] students)
        {
            _students= students;
        }
        private Student[] _students = new Student[10];

        public Student this[int i]
        {
            get => _students[i];
            set
            {
                if (!HasStudent(value.Fullname))
                    _students[i] = value;
                else
                    throw new DublicateStudentException();
            }
        }

        public bool HasStudent(string fullname)
        {
            foreach (var item in _students)
            {
                if (item.Fullname == fullname) return true;
            }
            return false;
        }
    }
}
