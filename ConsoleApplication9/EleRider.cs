using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    /// <summary>
    /// 饿了么骑手
    /// </summary>
    public class EleRider : Rider
    {
        public EleRider(Merchant merchant) : base(merchant)
        {
        }

        public override void Room()
        {
            Console.WriteLine("饿了么骑手出发去商户抢单");
        }
    }

    /// <summary>
    /// 美团骑手
    /// </summary>
    public class MeiTuanRider : Rider
    {
        public MeiTuanRider(Merchant merchant) : base(merchant)
        {
        }

        public override void Room()
        {
            Console.WriteLine("美团骑手出发去商户抢单");
        }
    }
}
