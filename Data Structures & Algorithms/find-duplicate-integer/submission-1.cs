public class Solution {
    public int FindDuplicate(int[] nums) {
        
        int n = nums.Length;
        Array.Sort(nums);
        for(int i = 0; i <n-1; i++)
        {
            if(nums[i] == nums[i+1])
            {
                return nums[i];
            }
        }
        return -1;
    }
}
