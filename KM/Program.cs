using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter KM");
            double x = double.Parse(Console.ReadLine());
            double y = 0;
            var time = DateTime.Now.Hour; 
            if (x <= 5)
            {
                y = 30;
                Console.WriteLine("KM: {0}  \nPrice: {1}", x, y);
            } else if (x > 5 && x <= 15)
            {
                if ((time < 7) || (time > 20))
                {
                    y = ((x - 5) * 2.3) + 30;
                }
                else
                {
                    y = ((x - 5) * 2.5) + 30;
                }

                Console.WriteLine("KM: {0}  \nPrce: {1} \nTime: {2}", x, y, DateTime.Now.ToString());
            } else if ( x > 15 && x <= 25)
            {
                if ((time < 7) || (time > 20))
                {
                    y = ((x - 5) * 2.1) + 30;
                }
                else
                {
                    y = ((x - 5) * 2.3) + 30;
                }
  
                Console.WriteLine("KM: {0}  \nPrce: {1} \nTime: {2}", x, y, DateTime.Now.ToString());
            } else if (x > 25) 
            {
                if ((time < 7) || (time > 20))
                {
                    y = ((x - 5) * 1.8) + 30;
                }
                else
                {
                    y = ((x - 5) * 2) + 30;
                }
                y = ((x - 5) * 2) + 30;
                Console.WriteLine("KM: {0}  \nPrce: {1} \nTime: {2}", x, y, DateTime.Now.ToString());
            }

        }
    }
}
