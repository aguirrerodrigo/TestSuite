using System;

namespace TestSuite.InterviewCake.AppleStocks
{
    public static class Solution
    {
        public static int GetMaxProfit(params int[] profits)
        {
            if (profits.Length <= 1)
                return 0;

            var maxProfit = profits[1] - profits[0];
            var minPrice = profits[0];
            for (int i = 1; i < profits.Length - 1; i++)
            {
                maxProfit = Math.Max(maxProfit, profits[i] - minPrice);
                minPrice = Math.Min(minPrice, profits[i]);
            }

            return maxProfit;
        }
    }
}