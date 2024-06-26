﻿using System;

namespace Lab9_10CharpT.task1
{
    internal class Task6
    {
        public double Result { get; private set; }

        public void Task(double x, double y)
        {
            try
            {
                if (x * y + 1 == 0)
                {
                    throw new Task6Exception("Division by zero error.");
                }

                Result = ((x * Math.Pow(y, 2) + Math.Pow(x, 2)) / (x * y + 1)) * (x - y);
            }
            catch (Task6Exception e)
            {
                Console.WriteLine("Task6Exception: " + e.Message);
                throw;
            }
        }
    }
}
