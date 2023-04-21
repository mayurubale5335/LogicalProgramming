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
                Console.WriteLine("Select an option 1.Fibonacci Series\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber\n5.CouponNumbers\n6.DayOfWeek\n7.TempConversion\n8.Exit");
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
                        Console.WriteLine("Enter the Number");
                        int P = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumberCheck(P);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Number");
                        int R = Convert.ToInt32(Console.ReadLine());
                        Reverse reverse = new Reverse();
                        reverse.ReverseNumber(R);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Number of Coupon");
                        int NUM = Convert.ToInt32(Console.ReadLine());
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.CreateNumber(NUM);
                        break;
                    case 6:
                        Console.WriteLine("Enter Day");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Month");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Year");
                        int y = Convert.ToInt32(Console.ReadLine());
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Get_Weekday(d, m, y);
                        break;
                    case 7:
                        Console.WriteLine("Select the Option 1. Celsius to Fahrenheit 2.Fahrenheit to  Celsius ");
                        int C = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Temperature");
                        int T = Convert.ToInt32(Console.ReadLine());
                        TempConversion tempConversion = new TempConversion();
                        tempConversion.Conversion(C, T);
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
