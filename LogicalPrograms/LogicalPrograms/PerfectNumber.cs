using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void Perfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    Console.WriteLine("{0}", i);
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n" + number + " Is a Perfect Number\n");
            }
            else
            {
                Console.WriteLine("\n" + number + " Is Not a Perfect  Number\n");
            }
        }
    }
}
