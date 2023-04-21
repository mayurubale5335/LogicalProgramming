using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programming");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select an option 1.Fibonacci Series\n2.PerfectNumber\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the length of the Series");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.CreateSeries(n);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Number");
                        int N = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfect(N);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
