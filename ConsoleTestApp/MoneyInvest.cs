using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes
{
    public class MoneyInvest
    {
        private decimal Principal = 1000;
        private decimal Rate = 0.05M;
        private decimal TaxRate = 0.18M;
        private decimal DesiredSum = 1100.00M;

        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;

            for (; principal < desiredPrincipal; years++)
            {
                //var earning = principal * interest;
                principal = principal + ((principal * interest) * (1-tax));
            }

            return years;
        }
    }
}
