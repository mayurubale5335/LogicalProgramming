using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class FibonacciSeries
    {
        public void CreateSeries(int n)
        {
            int a = -1, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine("");
        }
    }
}
