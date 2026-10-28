public class Solution {
    public int Search(int[] nums, int target) {
        
        for(int row = 0; row <nums.Length; row++)
        {
            if(nums[row] == target)
            {
                return row;
            }
        }
            return -1;
    }
}
