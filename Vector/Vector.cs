using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Lenght { get { return Y - X + 1; } }

        public Vector(int x,int y)
        {
            X = x;
            Y = y;
        }
        public Vector() { }
        public void SetVector()
        {
            int y;
            Console.WriteLine("Enter X ");
            X = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter Y ");
                y = int.Parse(Console.ReadLine());
            } while (y < X);
            Y = y;           
        }
    }
}
