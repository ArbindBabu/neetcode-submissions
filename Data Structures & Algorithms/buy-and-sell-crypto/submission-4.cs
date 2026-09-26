public class Solution {
    public int MaxProfit(int[] prices) {
        
        int res = 0;
        int buy, sell;
        int p = prices.Length;

        for(int i = 0; i <p; i++)
        {
            buy = prices[i];

            for(int j = i+1; j <p; j++)
            {
                sell = prices[j];
                 res = Math.Max(res, sell - buy);
            } 
           
        }
        return res;
    }
}
