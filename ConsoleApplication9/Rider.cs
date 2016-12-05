using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public abstract class Rider
    {
        protected Rider(Merchant customer)
        {
            customer.CallEvent += Room;
        }

        /// <summary>
        /// 送餐
        /// </summary>
        public abstract void Room();
    }
}
