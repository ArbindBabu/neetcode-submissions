public class Solution {
    public int MaxArea(int[] heights) {
        
        int res = 0;
        int i = 0, j = heights.Length-1;

        while(i < j)
        {
            int area = (Math.Min(heights[i],heights[j])) *(j - i);
            res = Math.Max(area,res);
            
            if(heights[i] <= heights[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return res;
    }
}
