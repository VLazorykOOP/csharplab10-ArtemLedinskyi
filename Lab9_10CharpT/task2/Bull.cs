using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.task2
{
    public class Bull
    {
        public event EventHandler WantToBuy;


        public void Buy()
        {
            Console.WriteLine("Бик хоче купити!");
            WantToBuy?.Invoke(this, EventArgs.Empty);   

        }
    }
}
