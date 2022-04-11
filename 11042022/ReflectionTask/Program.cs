using System;
using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student
            {
                Name = "Hikmet1",
                GroupNo = "123"
            };

            Student std2 = new Student
            {
                Name = "Hikmet2",
                GroupNo = "123"

            };

            Student std3 = new Student
            {
                Name = "Hikmet3",
                GroupNo = "123"
            };

            Employee emp1 = new Employee(1300)
            {
                Name = "Hikmet 4"
            };
            Employee emp2 = new Employee(2300)
            {
                Name = "Hikmet 5"

            };
            Employee emp3 = new Employee(3300)
            {
                Name = "Hikmet 6"
            };

            Human[] humen = { std1, std2, std3, emp1, emp2, emp3 };

            Console.WriteLine(CalcSalary(humen));
            
        }

        static double CalcSalary(Human[] humans)
        {
            double sum = 0;
            for (int i = 0; i < humans.Length; i++)
            {
                Type type = humans[i].GetType();
               
                foreach (var item in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    if(item.Name == "_salary")
                    {
                        var val = item.GetValue(humans[i]);
                        sum += (double)val;
                    }
                }
            }

            return sum;
        }
    }
}
