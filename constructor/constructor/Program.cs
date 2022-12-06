using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Customer
    {
        public int customer_id;
        public string customer_name;
        public Customer()
        {
            Console.WriteLine("this is default constructor");
            this.customer_id = 10;
            this.customer_name = "ravi";
            Console.WriteLine("{0} ,{1}", customer_name, customer_id);
        }
        public Customer(int custid, string custname)
        {
            this.customer_id=custid;
            this.customer_name=custname;
            Console.WriteLine("{0} ,{1}", custid,custname);
        }
        public Customer(Customer c)
        {
            this.customer_id=c.customer_id;
            this.customer_name=c.customer_name;
            Console.WriteLine("{0} ,{1}", c.customer_name, c.customer_id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cc= new Customer();
            Customer cc2= new Customer(102,"kunil");
            Customer cc3 = new Customer();
            cc3.customer_id = 103;
            cc3.customer_name = "suresh";
            Customer cc4= new Customer(cc3);
            Console.ReadLine();
        }
    }
}
