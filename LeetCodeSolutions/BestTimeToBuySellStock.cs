using System;

namespace LeetCodeSolutions
{
    public static class BestTimeToBuySellStock
    {
        public static int Solution(int[] prices)
        {
            //First Solution (2 Loops)
            // int maxProfit = 0;
            // int cheapestStock = 10000;
            // for (int i = 0; i < prices.Length - 1; i++)
            // {
            //     if (prices[i] < cheapestStock) 
            //     {
            //         cheapestStock = prices[i];
            //         for (int j = i + 1; j < prices.Length; j++)
            //         {
            //             int priceDiff = prices[j] - cheapestStock;
            //             if (priceDiff > 0)
            //             {
            //                 maxProfit = Math.Max(maxProfit, priceDiff);
            //             }
            //         }
            //     }
            // }
            // return maxProfit;
            
            //Second Solution (1 Loop; cuts runtime in half)
            if (prices.Length == 0) return 0;
            
            int maxProfit = int.MinValue;
            int cheapestStock = int.MaxValue;
            
            for (int i = 0; i < prices.Length; i++)
            {
                //keep track of cheapest stockprice
                cheapestStock = Math.Min(cheapestStock, prices[i]);
                //See if it will provide the most profit compared to the current stock price
                maxProfit = Math.Max(maxProfit, prices[i] - cheapestStock);
            }
            
            return maxProfit;
        }
    }
}