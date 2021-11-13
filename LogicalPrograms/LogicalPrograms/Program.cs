using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option To Execute the Program\n 1.FibonacciSeries\n 2.ReverseOfNumber\n 3.PrimeNumber\n 4.PerfectNumber\n 5.TemperatureConversion\n 6.DayOfWeek\n 7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter The Number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries result = new FibonacciSeries();
                        result.Fibonacci(number);
                        break;
                    case 2:
                        Console.WriteLine("Enter The Number");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        ReverseOfaNumber result1 = new ReverseOfaNumber();
                        result1.Reverse(number1);
                        break;
                    case 3:
                        Console.WriteLine("Enter The Number");
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber result2 = new PrimeNumber();
                        result2.Prime(number2);
                        break;
                    case 4:
                        Console.WriteLine("Enter The Number");
                        int number3 = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber result3 = new PerfectNumber();
                        result3.Perfect(number3);
                        break;
                    case 5:
                        Console.WriteLine("Enter The Day: ");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Week: ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The year: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        DayOfaWeek result5 = new DayOfaWeek();
                        result5.Day(day, month, year);
                        break;
                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option..\n");
                        break;
                }
            }

        }
    }
}