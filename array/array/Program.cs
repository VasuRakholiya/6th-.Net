using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, j, sum = 0;
            Console.WriteLine("\n reading array");
            for(i=0;i<a.Length;i++)
            {
                Console.WriteLine("enter element[{0}]",i+1);
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n printing the array");
            for(i=0;i< a.Length;i++)
            {
                Console.WriteLine("{0,4}", a[i]);
            }
            Console.WriteLine("\n calculating sum of elements in array");
            for(i=0;i< a.Length ;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("\n total sum of array is {0}", sum);
            Console.WriteLine("\n displaying array using for each loop");
            foreach(int ele in a)
            {
                Console.WriteLine("{0,4}", ele);
            }
            Console.WriteLine("\n enter the element to be searched in array");
            int searchele=Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=a.Length;i++)
            {
                if (a[i]==searchele)
                {
                    Console.WriteLine("the element {0} is found at {1} position",searchele,i+1);
                }
            }
            Console.WriteLine("\n sortint in array");
            for (i = 0; i < a.Length; i++)
            {
                for(j=i+1;j<a.Length;j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("\n array after sorting");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("{0,4}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
