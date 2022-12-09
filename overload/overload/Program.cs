using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class abcd
    {
        public void add(int x,int y)
        {
            Console.WriteLine("the sum is {0}" , ( x + y ) );
        }
        public decimal add(int x,float kk,decimal cc)
        {
            return (x + Convert.ToDecimal(kk) + cc);
        }
        public double add(int x,decimal ss,double dd)
        {
            return(x+ Convert.ToDouble(ss) + dd);
        }
    }
    class cde : abcd
    {
        public void add(int x,int c)
        {
            Console.WriteLine("the sum is {0}", (x + c));
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            cde cc= new cde();
            cc.add(12, 'a');
            cc.add(12, 13);
            Console.WriteLine("{0}",cc.add(12, 45.6m, 345.89));
            Console.WriteLine("{0}", cc.add(13, 45.6f, 345.45m));
            Console.ReadLine();
        }
    }
}
