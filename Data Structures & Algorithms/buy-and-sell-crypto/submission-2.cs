public class Solution {
    public int MaxProfit(int[] prices) {
        
        int i,j;
        int res = 0;
        int p = prices.Length;

        for(i = 0; i <p; i++)
        {
            int buy = prices[i];
            
            for(j = i+1; j <p; j++)
            {
                int sell = prices[j];

                res = Math.Max(res, sell - buy);
            }
        }
        return res;
    }
}
