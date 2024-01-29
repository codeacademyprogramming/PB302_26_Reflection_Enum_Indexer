using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Teacher:Human
    {
        public Teacher(double salary)
        {
            _salary= salary;
        }
        private double _salary;
        public void SetNewSalary(double salary)
        {
            _salary = salary;
        }
    }
}
