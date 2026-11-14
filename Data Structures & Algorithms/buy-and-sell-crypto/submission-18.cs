public class Solution {
    public int MaxProfit(int[] prices) {
        
        int p = prices.Length;
        int buy, sell;
        int res = 0;
        for(int i  = 0; i <p; i++)
        {
            buy = prices[i];

            for(int j = i+1; j <p; j++)
            {
               sell =  prices[j];
                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
