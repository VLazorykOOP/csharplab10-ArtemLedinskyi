using System;

namespace Lab9_10CharpT.task1
{
    internal class Task2
    {
        public string Result { get; private set; }

        public void Task(int num)
        {
            try
            {
                if (!IsTwoDigitNumberForTask2(num))
                {
                    throw new ArgumentException("Введено не двозначне число");
                }

                string result = IsSumDivByThreeForTask2(num) ?
                    $"Сума цифр числа {num} кратна 3." :
                    $"Сума цифр числа {num} не кратна 3.";

                Result = result;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException: " + e.Message);
                throw;
            }
        }

        public bool IsTwoDigitNumberForTask2(int num)
        {
            return num >= 10 && num <= 99;
        }

        public bool IsSumDivByThreeForTask2(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum % 3 == 0;
        }
    }
}
