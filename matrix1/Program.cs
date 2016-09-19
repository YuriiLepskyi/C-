using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int main = 0;
            int adverse = 0;
            int[][] array;
            Console.WriteLine("Enter: i");
            i= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter: j");
            j = int.Parse(Console.ReadLine());
            array = new int[i][];
            for (int a = 0; a < i; a++)
            {
                array[a] = new int[j];
                for (int b = 0; b < j; b++)
                {
                    Console.WriteLine(string.Format("Enter value to array [{0}][{1}]", a, b));
                    array[a][b] = int.Parse(Console.ReadLine());
                }
            }
            for (int c = 0; c < i; c++)
            {
                Console.WriteLine();
                for (int d = 0; d < j; d++)
                {
                    Console.Write(array[c][d]);
                }
            }
            Console.WriteLine();
            if (i == j)
            {
                for (int z = 0; z < j; z++)
                {
                    main = main + array[z][z];
                }
                Console.WriteLine(main);

                for (int w = j - 1; w >= 0; w--)
                {
                    adverse = adverse + array[w][w];
                }
                Console.WriteLine(adverse);
            }
            else
            {
                Console.WriteLine("Can`t resolve sum of diagonals because i!=j!");
            }
        }
    }
}
