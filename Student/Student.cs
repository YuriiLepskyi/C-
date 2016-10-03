using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string _lastName;
        private string _firstName;
        private string FullName
            {
                get { return string.Format("{0} {1}", _firstName, _lastName); }
            }


        private string _street;
        private string _city;
        private int _namOfByld;
        private string Address
        {
            get { return string.Format("{0} {1} {2}", _city, _street, _namOfByld); }
        }


        private int[]_marks;
        private int average
        {
            get
            {
                int temp = 0;
                for (int i = 0; i < _marks.Count(); i++)
                {
                    temp = temp + _marks[i];
                }
                temp = temp / _marks.Count();
                return temp;  
            }            
        }
        public int CalcAverage ()
        {
            int temp = 0;
            for (int i = 0; i <_marks.Count(); i++)
            {
                temp = temp + _marks[i];
            }
            temp = temp / _marks.Count();
            return temp;
        }
        public Student ()
        {
            _lastName = "Lepskyi";
            _firstName = "Yurii";
            _city = "Lviv";
            _street = "Kylparkiv";
            _namOfByld = 125;
            _marks = new int[5] { 7, 9, 10, 9, 5 };


        }
        public Student(string firstName, string lastName, string city, string street, int namOfByld, int[] marks)
        {
            _lastName = lastName;
            _firstName = firstName;
            _city = city;
            _street = street;
            _namOfByld = namOfByld;
            _marks = marks;
        }
            public void GetInfo ()
        {
            Console.WriteLine(string.Format("Full name: {0}\nAddress: {1}\nMarks: ", FullName, Address));
            for(int i =0; i < _marks.Count(); i++)
            {
                Console.Write(string.Format("{0} ",_marks[i]));
            }
            Console.WriteLine(string.Format ("\nAverage: {0}",average));            
        }
    }
}




















