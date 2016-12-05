using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    /// <summary>
    /// 川菜馆
    /// </summary>
    public class ChuanCai : Merchant
    {
        public override void Notify()
        {
            Console.WriteLine("做饭完毕……");
            Console.WriteLine("通知骑手中……");
            base.Notify();
        }
    }
}
