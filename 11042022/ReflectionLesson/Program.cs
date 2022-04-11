using ReflectionLesson.Classes;
using System;
using System.Reflection;

namespace ReflectionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student(85)
            {
                Age = 45,
                Name = "Hikmet"
            };

            WarrantyStudent wstd1 = new WarrantyStudent(55, "AP203")
            {
                Name = "Nermin Abbaszade"
            };

            var assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine(item.Name+" properties:");

                foreach (var pr in item.GetProperties())
                {
                    Console.WriteLine($"\t {pr.Name}");
                }

                Console.WriteLine(item.Name + " fields:");

                foreach (var pr in item.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    Console.WriteLine($"\t {pr.Name}");
                }
            }

            var studentType = typeof(Student);

            Console.WriteLine("Student fields:");
            foreach (var item in studentType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Student value");

            foreach (var fld in studentType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
            {
                if (fld.Name == "_point")
                {
                    var ageValue = fld.GetValue(std1);
                    Console.WriteLine("age: "+ageValue);
                }
            }


            Console.WriteLine("\n=====================================\n");

            Student student = wstd1;

            var type = student.GetType();

            foreach (var item in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine(item.Name);
            }

        }

    }
}
