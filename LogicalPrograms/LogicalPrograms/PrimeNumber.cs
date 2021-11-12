using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void Prime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(number + " Is a Prime Number\n");
            }
            else
            {
                Console.WriteLine(number + " Is Not a Prime Number\n");
            }
        }
    }
}