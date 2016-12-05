using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public abstract class CustomerObserver
    {
        public delegate void Order(string name);

        public event Order OrderEvent;

        public void OrderFood()
        {
            OrderEvent?.Invoke("");
        }
    }
}
