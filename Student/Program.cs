using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Yurii", "Lepskyi", "Lviv", "Kylparkiv", 125, new int[5] { 7, 9, 10, 9, 5 });
            Student s2 = new Student();
            s1.GetInfo();
            s2.GetInfo();
        }
    }
}
