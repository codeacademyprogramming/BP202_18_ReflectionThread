using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLesson.Classes
{
    internal class Student
    {
        public Student(int point)
        {
            _point = point;
        }
        private int _point;
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name { get; set; }

    }
}
