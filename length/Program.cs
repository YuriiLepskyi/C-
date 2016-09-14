using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace length 
{
    class Program
    {
        static void Main(string[] args)
        {
            
             const float pi = 3.141591f;
             Console.WriteLine("Введiть радiус");
             float radius = float.Parse(Console.ReadLine());
             float result = 2*pi*radius;

            Console.WriteLine(result);
        }
    }
}
