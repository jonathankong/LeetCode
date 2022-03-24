using System;

namespace LeetCodeSolutions
{
    public static class BestTimeToBuySellStock2
    {
        public static int Solution(int[] prices)
        {
            //3 pointers: 1 will be as if I bought the cheapest stock and held
            //1 will be as if I was buying and selling stock
            //1 will be keeping track of the current stock price
            //Compare the two profits and decide which profit to keep as the window grows to the end of the array
            
            if (prices.Length == 0) return 0;
            
            int cheapestStock = int.MaxValue;
            int cheapestStockProfit = int.MinValue;
            int buySellStock = int.MaxValue;
            int buySellStockProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                cheapestStock = Math.Min(cheapestStock, prices[i]);
                cheapestStockProfit = Math.Max(cheapestStockProfit, prices[i] - cheapestStock);
                
                buySellStock = Math.Min(buySellStock, prices[i]);
                
                if (prices[i] > buySellStock)
                {
                    buySellStockProfit += prices[i] - buySellStock;
                    buySellStock = prices[i];
                }
            }
            
            return Math.Max(cheapestStockProfit, buySellStockProfit);
        }
    }
}