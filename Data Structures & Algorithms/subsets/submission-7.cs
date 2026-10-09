public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        int num = nums.Length;
        List<List<int>> res = new ();
        for(int i = 0; i <(1 << num); i++)
        {
            List<int> sub = new();
            for(int j = 0; j <num; j++)
            {
                if((i &(1<< j)) != 0)
                {
                    sub.Add(nums[j]);
                }
            }
            res.Add(sub);
        }
        return res;
    }
}
