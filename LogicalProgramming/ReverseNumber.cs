using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class Reverse
    {
        public void ReverseNumber(int R)
        {
            int result = 0;
            while(R != 0)
            {
                int rem = (R % 10);
                result = result * 10 + rem;
                R = R / 10;
            }
            Console.WriteLine("Reversed Number is {0}", result);
        }
    }
}
