public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int i,j;
        int num = nums.Length;

        for(i = 0; i <num; i++)
        {
            for(j = i+1; j <num; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[]{i,j};
                }
            }
        }
        return new int[0];
    }
}
