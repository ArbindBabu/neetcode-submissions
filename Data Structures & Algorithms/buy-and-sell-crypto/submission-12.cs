public class Solution {
    public int MaxProfit(int[] prices) {
        
        int i, j;
        int buy, sell;
        int res = 0;
        int p = prices.Length;

        for(i = 0; i <p; i++)
        {
            buy = prices[i];
            for(j = i; j <p; j++)
            {
                sell = prices[j];
                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
