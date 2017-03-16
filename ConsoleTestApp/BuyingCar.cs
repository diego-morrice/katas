using System;

namespace Codes
{
    public class BuyingCar
    {
        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
        {

           var result = new[]{0,0}; int savings = 0;
           double oldOne = startPriceOld; double newOne = startPriceNew;

            while ((oldOne + savings < newOne && oldOne < newOne))
            {
                oldOne = oldOne * (1-percentLossByMonth/100);
                newOne = newOne * (1-percentLossByMonth/100);
                savings += savingperMonth;

                if (result[0] % 2 == 0) percentLossByMonth += 0.5;

                result[0]++;
            }

            result[1] = Convert.ToInt32(oldOne + savings - newOne);

            return result;
        }
    }
}
