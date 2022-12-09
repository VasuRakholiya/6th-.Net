using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class abcd
    {
        public int a;
        public abcd()
        {

        }
        public abcd(int k)
        {
            a = k;
        }
        public static abcd operator +(abcd ab, abcd ab1)
        {
            abcd first = new abcd();
            first.a = ab.a + ab1.a;
            return first;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            abcd ab = new abcd(10);
            abcd ab1 = new abcd(20);
            abcd ab2 = new abcd();

            ab2 = ab + ab1;//+ operator can not overload directly
            Console.WriteLine("the sum is {0}", ab2.a);
            Console.ReadLine();
        }
    }
}
