using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count;
            bool isEqual = true;
            word = Console.ReadLine();
            count = word.Count ();
            int lastElementIndex = count - 1;
            for (int i = 0; i < count / 2; i++) 
            {
                if (word[i] != word[lastElementIndex - i])
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Word is polindrom:");
            }
            else
            {
                Console.WriteLine("Word is not polindrom");
            }
        }
    }
}
