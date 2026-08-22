public class Solution 
{
    public int FirstMissingPositive(int[] nums) 
    {
        Array.Sort(nums);
        int missing = 1;

        foreach(int num in nums)
        {
            if(num > 0 && num == missing)
            {
                missing ++;
            }
        }
        return missing;
    }
}