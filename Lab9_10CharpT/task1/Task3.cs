using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.task1
{
    internal class Task3
    {

        public string Task(int x, int y)
        {
            return (x > -50 && x < 50 && y > -25 && y < 25) ? "Так"
                          : (x == -50 & x == 50 & y == -25 & y == 25) ? "На межі" : "Ні";
        }
    }
}
