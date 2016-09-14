using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {           

            Console.WriteLine("Write the student's name");
            string name = Console.ReadLine();

            Console.WriteLine("mathematics");
            float mathematics = float.Parse(Console.ReadLine());

            Console.WriteLine("biology");
            float biology = float.Parse(Console.ReadLine());

            Console.WriteLine("physics");
            float physics = float.Parse(Console.ReadLine());

            float arithmetic = (mathematics + biology + physics)/3;
            Console.WriteLine("arithmetic  " + arithmetic + "  Student  " + name);
        }
    }
}
