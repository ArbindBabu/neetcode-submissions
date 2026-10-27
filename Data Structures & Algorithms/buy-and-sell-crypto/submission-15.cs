public class Solution {
    public int MaxProfit(int[] prices) {
        
        int i, j,buy, sell, res = 0;
        int price = prices.Length;

        for(i = 0; i <price; i++)
        {
            buy = prices[i];
            for( j = i; j <price; j++)
            {
                sell = prices[j];
                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
