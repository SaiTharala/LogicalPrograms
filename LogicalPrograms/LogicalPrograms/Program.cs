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
                Console.WriteLine("Choose an Option To Execute the Program\n 1.FibonacciSeries\n 2.Exit");
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
