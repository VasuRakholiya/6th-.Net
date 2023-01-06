using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggingin.net
{
    class Employee
    {
        public void totalsalary(int salary ,int bonus)
        {
            Console.WriteLine("The total salary is --1" + (salary + bonus));
            Console.WriteLine("The total salary is--2 " + (salary + bonus));
            Console.WriteLine("The total salary is--3 " + (salary + bonus));
            Console.WriteLine("The total salary is--4 " + (salary + bonus));
            Console.WriteLine("The total salary is--5 " + (salary + bonus));
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Employee();
            ee.totalsalary(23000, 4000);
            Console.WriteLine("hello world");
            Console.WriteLine("hai");
            Console.ReadLine();

        }
    }
}
