using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class CouponNumbers
    {
        public void CreateNumber(int NUM)
        {
            int[] a = new int[NUM];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1000, 5000);
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[i] = random.Next(1000, 5000);
                    }
                }
                Console.WriteLine("Coupon" + (i + 1) + ":" + a[i]);
            }

        }
    }
}
