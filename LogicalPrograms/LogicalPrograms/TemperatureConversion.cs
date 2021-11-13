using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TemperatureConversion
    {
        float convert;
        public void Temp(int temp, char unit)
        {
            if (unit == 'c' || unit == 'C')
            {
                convert = (temp * 9 / 5) + 32;
            }
            else if (unit == 'f' || unit == 'F')
            {
                convert = (temp - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Enter correct input");
            }
            Console.WriteLine("After Conversion Temperature is: " + convert);
        }
    }
}