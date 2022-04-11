using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLesson.Classes
{
    internal class WarrantyStudent:Student
    {
        string _prevGroupNo;
        public WarrantyStudent(int point,string prevGroupNo):base(point)
        {
                _prevGroupNo = prevGroupNo;
        }
    }
}
