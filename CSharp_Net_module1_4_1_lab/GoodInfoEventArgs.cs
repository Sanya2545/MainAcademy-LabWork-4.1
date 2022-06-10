using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    // 1) inherit EventArgs
    class GoodsInfoEventArgs: EventArgs
    {
        // 2) declare property GoodsName
        public string  GoodsName{ get; set; }
        // think about get and set attributes

        public GoodsInfoEventArgs(string goodsName = "")
        {
            GoodsName = goodsName;
        }
        // 3) declare constructor to initialize GoodsName

    }
}
