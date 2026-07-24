Console.WriteLine(MaxProfit([2, 1, 2, 1, 0, 1, 2]));


static int MaxProfit(int[] prices)
{
    int buy = prices[0];
    int sell = 0;
    int profit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < buy) 
        {
            buy = prices[i];
            sell = prices[i];
        }

        if (prices[i] > sell)
        {
            sell = prices[i];

            int currentProfit = sell - buy;

            if (currentProfit > profit)
            {
                profit = currentProfit;
            }
        }
    }

    return profit;
}