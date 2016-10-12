using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = new Vector[10];
            for(int i = 0;i<vectors.Count();i++)
            {
                vectors[i] = new Vector();
                vectors[i].SetVector();
            }
            foreach (var v in vectors)
            {
                if (v.Lenght > 5) 
                {
                    Console.WriteLine(string.Format("X:{0} Y:{1} Sum:{2}", v.X, v.Y, v.Lenght));
                }else
                {
                    Console.WriteLine(string.Format("X:{0} Y:{1}", v.X, v.Y));
                }
            }
        }
    }
}
