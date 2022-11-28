using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter=1;
            //while (counter <= 100)
            //{
            //    Console.Write("{0,5}",counter);
            //    counter = counter + 1;
            //}

            do
            {
                Console.WriteLine("{0,5}",counter);
                counter++;
            }while(counter <=100);
            Console.ReadLine();
        }
    }
}
