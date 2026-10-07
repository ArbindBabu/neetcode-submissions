public class Solution {
    public int MaxProfit(int[] prices) {
        
        int i,j;
        int res = 0;
        int buy, sell;
        int n = prices.Length;

        for(i = 0; i <n; i++)
        {
            buy = prices[i];
            for(j = i+1; j <n; j++)
            {
                sell = prices[j];
                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
