using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.task2
{
    public class Bear
    {

        public event EventHandler WantToSell;

        public void Sell()
        {
            Console.WriteLine("Відмідь хоче продати!");
            WantToSell?.Invoke(this, EventArgs.Empty);
        }
    }
}
