using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f = 1.0f;
            int n;
            int i;
            Console.WriteLine("enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=n;i++)
            {
                f = f * i;
            }
            Console.WriteLine("the fact of {0} and {1}", n, f);
            Console.ReadLine();
        }
    }
}
