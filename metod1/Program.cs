using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum("String 1", 5, 12, 38);
        }
        static void Sum(string a, params int [] number)
        {
            int sum = 0;
            for(int i=0;i<number.Length;i++)
            {
                sum += number[i];
            }    
            if (sum > 20) 
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Sorry sum<20");
            } 
        }
    }
}
