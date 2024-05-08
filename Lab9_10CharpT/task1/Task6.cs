using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task1
{
    internal class Task6
    {
        public double Task(double x, double y)
        {
            try
            {
                if (x * y + 1 == 0)
                {
                    throw new Task6Exception("Division by zero error.");
                }

                return ((x * Math.Pow(y, 2) + Math.Pow(x, 2)) / (x * y + 1)) * (x - y);
            }
            catch (Task6Exception e)
            {
                Console.WriteLine("Task6Exception: " + e.Message);
                throw; 
            }
        }
    }
    }
