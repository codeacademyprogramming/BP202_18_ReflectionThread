using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionTask
{
    internal class Employee:Human
    {
        public Employee(double salary)
        {
            _salary = salary;
        }
        double _salary;
    }
}
