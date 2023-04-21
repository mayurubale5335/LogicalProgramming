using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class TempConversion
    {
        public void Conversion(int C, int T)
        {
            switch (C)
            {
                case 1:
                    int F = (T * 9 / 5) + 32;
                    Console.WriteLine(F);
                    break;
                case 2:
                    int D = (T - 32) * 5 / 9;
                    Console.WriteLine(D);
                    break;
            }
        }
    }
}
