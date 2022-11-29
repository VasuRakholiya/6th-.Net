using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,c,choice;
            Console.WriteLine("enter values of a and b");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("1.addition");
                Console.WriteLine("2.subtraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.divison");
                Console.WriteLine("enter choice...");

                choice= Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: c = a + b;
                        Console.WriteLine("sum is {0}", c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("sub is {0}", c);
                        break;
                    case 3:
                        c = a * b;
                        Console.WriteLine("mul is {0}", c);
                        break;
                    case 4:
                        c = a / b;
                        Console.WriteLine("div is {0}", c);
                        break;
                    default: Console.WriteLine("enter valid value");
                        break;
                }
                Console.WriteLine("do you want to continue <y/n>");
                if(Console.ReadLine()!="y")
                {
                    break;
                }
            }while(true);
        }
    }
}
