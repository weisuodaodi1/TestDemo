using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    /// <summary>
    /// 商户
    /// </summary>
    public abstract class Merchant
    {
        public delegate void CallDelegate();

        public event CallDelegate CallEvent;

        /// <summary>
        /// 通知
        /// </summary>
        public virtual void Notify()
        {
            CallEvent?.Invoke();
        }


    }
}
