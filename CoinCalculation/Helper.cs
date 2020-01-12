using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinCalculation
{
    public static class Helper
    {
        public static string[] Calculate(int[] coinDenominations, decimal cost, decimal amountPaid)
        {
            var result = new List<string>();
            //Convert into cents, this way no funky divisions are made (I.E working with integers)
            var amountOwed = (amountPaid - cost) * 100;

            foreach (var denomination in coinDenominations)
            {
                while (denomination <= amountOwed)
                {
                    amountOwed -= denomination;
                    result.Add(denomination.ToString());
                }
            }

            return result.ToArray();
        }
    }
}
