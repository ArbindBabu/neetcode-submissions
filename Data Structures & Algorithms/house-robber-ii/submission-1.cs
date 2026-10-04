public class Solution {
    public int Rob(int[] nums) {
        
        if(nums.Length == 1)
        return nums[0];

        return Math.Max(Helper(nums[1..]), Helper(nums[..^1]));
    }
    private int Helper(int[] nums)
    {
        int rob1 = 0;
        int rob2 = 0;
        foreach(int num in nums)
        {
            int temp = Math.Max(num + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
            temp = rob1;
        }
        return rob2;
    }
}
