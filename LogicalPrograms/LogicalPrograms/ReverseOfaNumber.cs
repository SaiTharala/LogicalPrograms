using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseOfaNumber
    {
        int reverseNumber = 0;
        public void Reverse(int number)
        {
            while (number > 0)
            {
                int remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse Of Entered Number is: " + reverseNumber + "\n");
        }
    }
}