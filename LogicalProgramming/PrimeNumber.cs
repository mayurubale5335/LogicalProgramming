using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PrimeNumber
    {
        public void PrimeNumberCheck(int P)
        {
            int flag = 0;
            for (int i = 2; i <= P / 2; i++)
            {
                if (P % i == 0)
                {
                    flag = 1;
                    break;
                }
                flag = 0;
            }
            if(flag == 0)
            {
                Console.WriteLine("{0} is Prime Number", P);
            }
            else
            {
                Console.WriteLine("{0} is not Prime Number", P);
            }
        }
                 
    }
}
