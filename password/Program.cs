using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            do
            {
                Console.WriteLine("Please enter password:");
                password = (Console.ReadLine());
            }
            while (password != "rotor");
            Console.WriteLine("OK");
        }
    }
}
