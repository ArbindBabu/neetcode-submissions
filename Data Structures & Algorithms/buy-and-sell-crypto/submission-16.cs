public class Solution {
    public int MaxProfit(int[] prices) {
        
        int i, j, buy, sell;
        int price = prices.Length;
        int res = 0;

        for(i = 0; i <price; i++)
        {
            buy = prices[i];
            for(j = i+1; j <price; j++)
            {
                sell = prices[j];
                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
