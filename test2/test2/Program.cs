using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print using do while");
            int counter = 1;
            bool keepgoing = true;

            do
            {
                Console.Write("{0,5}", counter);
                if(counter%100==0 && counter!=0)
                {
                    Console.WriteLine("\n keep counting..<y/n>");
                    if(Console.ReadLine()!="y")
                    {
                        keepgoing = false;
                    }
                }
                counter++;
            } while (keepgoing);
            Console.WriteLine("finish counting");
            Console.ReadLine();
        }YieldAwaitable

    }
}
