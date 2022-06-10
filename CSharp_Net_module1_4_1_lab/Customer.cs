using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Customer
    {
        private string name;
        // 6) declare private field name
        public Customer(string name = "")
        {
            this.name = name;
        }

        // 7) declare constructor to initialize name
      

        // 8) declare method GotNewGoods with 2 parameters:
        public void GotNewGoods(object type, GoodsInfoEventArgs args)
        {

        }
        // 1 - object type
        // 2 - GoodsInfoEventArgs type
        
    }
}
