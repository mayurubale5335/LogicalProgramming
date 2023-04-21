using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PerfectNumber
    {
        public void CheckPerfect(int N)
        {
            int sum = 0;
            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == N)
            {
                Console.WriteLine("{0} is Perfect Number", N);
            }
            else
            {
                Console.WriteLine("{0} is Not Perfect Number", N);
            }
        }
    }
}
