using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ramadhan", 18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Dwi", 30, "191128", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Saputra", 18, "2851", "ramadhandwisaputra.1012@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}