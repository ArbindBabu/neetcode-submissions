public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        int i , j;
        int n = nums.Length;

        for(i = 0; i < n; i++)
        {
            for(j = i + 1; j < n; j++)
            {
                if(nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}