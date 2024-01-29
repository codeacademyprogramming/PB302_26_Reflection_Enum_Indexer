using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLesson.Exceptions
{
    internal class DublicateStudentException:Exception
    {
        public DublicateStudentException():base("Student already exists!")
        {

        }
        public DublicateStudentException(string message) : base(message)
        {

        }
    }
}
