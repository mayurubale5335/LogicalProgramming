using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class MonthlyPayment
    {
        public void CalculatePayment(double Amount,double Year,double Rate)
        {
            double n = 12 * Year;
            double r = Rate / (12 * 100);
            double a = Math.Pow((1 + r), -n);
            double Payment = (Amount * r) / (1 - a);
            Console.WriteLine("Monthly Payment = " + Payment);
        }
    }
}
