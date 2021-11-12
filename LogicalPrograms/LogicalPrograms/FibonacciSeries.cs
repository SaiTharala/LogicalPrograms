using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        int first = 0, second = 1, third = 0;
        public void Fibonacci(int number)
        {
            if (number == 0)
            {
                Console.WriteLine(first);
                return;
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < number; i++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
        }
    }
}