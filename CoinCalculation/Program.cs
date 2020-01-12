using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "", cost = "", amountPaid = "";
            bool validDenominations = false, validCost = false, validAmount = false;

            Console.WriteLine("Please enter comma seperated denominations:");

            input = Console.ReadLine();

            while (validDenominations)
            {
                if (!string.IsNullOrEmpty(input) && input.Contains(",") && input.Split(',').All(c => c.All(char.IsDigit)))
                    validDenominations = true;

                Console.WriteLine("Please enter valid denominations:");
                input = Console.ReadLine();
            }

            Console.WriteLine("Please enter vendor cost:");
            cost = Console.ReadLine();

            while (validCost)
            {
                if (cost.All(c => char.IsDigit(c)))
                    validCost = true;

                Console.WriteLine("Please enter valid cost:");
                cost = Console.ReadLine();
            }

            Console.WriteLine("Please enter amount paid:");
            amountPaid = Console.ReadLine();

            while (validAmount)
            {
                if (amountPaid.All(c => char.IsDigit(c)))
                    validAmount = true;

                Console.WriteLine("Please enter valid amount paid:");
                amountPaid = Console.ReadLine();
            }

            var denominations = input.Split(',').Select(int.Parse).OrderByDescending(c => c).ToArray();

            var coins = Helper.Calculate(denominations, Convert.ToDecimal(cost), Convert.ToDecimal(amountPaid));

            Console.WriteLine($"Coins Returned: {string.Join(",", coins)}");
            Console.Read();
        }
    }
}
