public class Solution {
    public int Search(int[] nums, int target) {
        
        int i;
        int n = nums.Length;
        for(i = 0; i <n; i++)
        {
            if(nums[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
