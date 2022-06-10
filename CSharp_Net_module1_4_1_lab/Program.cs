using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop onlineShop = new OnlineShop();
            GoodsInfoEventArgs eventArgs = new GoodsInfoEventArgs("Groceries");
            // 10) declare several objects of Customer
            onlineShop.Event += onlineShopMyEvent;
            onlineShop.NewGoods("Iphone");
            Console.ReadKey();

            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results

        }

        private static void onlineShopMyEvent(object sender, GoodsInfoEventArgs eventArgs)
        {
            Console.WriteLine("Event" + eventArgs.GoodsName);
        }
    }
}
