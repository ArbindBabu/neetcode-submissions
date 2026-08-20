public class Solution 
{
    public int MinCostClimbingStairs(int[] cost) 
    {
        int i;
        int current;
        int n = cost.Length;
        int pr1 = 0, pr2 = 0;
        for(i = 2; i<= n; i++)
        {
            current = Math.Min(
             pr1 + cost[i-1],
             pr2 + cost[i-2]
            );
            pr2 = pr1;
            pr1 = current;

        }
        return pr1;
    }
}
