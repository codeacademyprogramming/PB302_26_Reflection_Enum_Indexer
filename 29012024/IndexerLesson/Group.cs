using IndexerLesson.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson
{
    internal class Group
    {
        public string No;
        public StudentList StudentList;
        public Group(string no)
        {
            No = no;
            this.StudentList = new StudentList();
        }

        public Group(string no, Student[] students)
        {
            No = no;
            this.StudentList = new StudentList(students);
        }

       

       
    }
}
