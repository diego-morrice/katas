using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Codes
{
    public class StockBroker
    {
        public static String balanceStatements(String lst)
        {

            if (string.IsNullOrEmpty(lst) || lst.Length == 0)
                return "Buy: 0 Sell: 0";

            double buyTotal = 0;
            double sellTotal = 0;
            var malFormed = new List<string>();

            var ordersRequested = lst.Split(',');

            for (var i = 0; i < ordersRequested.Length; i++)
            {
                int intTest = 0;
                double doubleTest = 0;
                var order = ordersRequested[i].Split(' ').ToList();

                if (string.IsNullOrEmpty(order[0]))
                    order.Remove(order[0]);

                if (order.Count != 4 || string.IsNullOrEmpty(order[0]) ||
                    (order[3].ToUpper() != "B" && order[3].ToUpper() != "S")
                    || !int.TryParse(order[1], out intTest) || !double.TryParse(order[2], out doubleTest) || !order[2].Contains("."))
                {
                    malFormed.Add(order.Aggregate((f, s) => f + " " + s) + " ;");
                    continue;
                }

                if (order[3].ToUpper() == "B")
                    buyTotal += int.Parse(order[1]) * double.Parse(order[2], CultureInfo.InvariantCulture);

                else
                    sellTotal += int.Parse(order[1]) * double.Parse(order[2], CultureInfo.InvariantCulture);
            }

            if (malFormed.Count > 0)
                return "Buy: " + buyTotal + " Sell: " + sellTotal + "; " + "Badly formed " + (malFormed.Count) + ": " + malFormed.Aggregate((i, j) => i + j);

            return "Buy: " + buyTotal + " Sell: " + sellTotal;

        }
    }
}
