using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.task2
{
    internal class Market
    {

        public void OnBuy(object sender, EventArgs e)
        {
            Console.WriteLine("Бик купив акції!");
        }
        public void OnSell(object sender, EventArgs e)
        {
            Console.WriteLine("Ведміть продав акції!");
        }
    }
}
