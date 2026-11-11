public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Dictionary<int,int> seen = new Dictionary<int,int>();
        for(int i = 0; i <numbers.Length; i++)
        {
            int tmp = target - numbers[i];
            if(seen.ContainsKey(tmp))
            {
                return new int[]{seen[tmp], i+1};
            }
            seen[numbers[i]] = i+1;
        }
        return new int[0];
    }
}
