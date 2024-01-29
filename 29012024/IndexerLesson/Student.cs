using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson
{
    internal class Student
    {
        public Student(string fullname,byte point)
        {
            this.Fullname= fullname;
            this.Point = point;
        }
        public string Fullname;
        public byte Point;

        public override string ToString()
        {
            return Fullname + " - " + Point;
        }
    }
}
