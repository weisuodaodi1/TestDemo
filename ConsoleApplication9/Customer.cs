using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class Customer 
    {
        private readonly string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public void Order(Merchant merchant)
        {
            Console.WriteLine(_name + "客户要订餐：");
            merchant.Notify();
        }
    }
}
