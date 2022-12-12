using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace static_function
{
    class abcd
    {
        public int count = 0;
        public  static void printcount()
        {
            abcd obj=new abcd();
            obj.count=obj.count+1;
            //count = count + 1;
           // Console.WriteLine("the value is {0}",count);
        }
    }
    class Program
    {
        static static void Main(string[] args)
        {
            abcd a = new abcd();
            abcd.printcount();
            abcd.printcount();
            //a.printcount();
            //a.printcount();
            Console.ReadLine();
        }
    }
}
