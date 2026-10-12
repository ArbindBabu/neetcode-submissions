public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Dictionary<int,int> sum = new Dictionary<int,int>();
        for(int i = 0; i <numbers.Length; i++)
        {
            int tmp = target - numbers[i];
            if(sum.ContainsKey(tmp))
            {
                return new int[]{sum[tmp], i+1};
            }
            sum[numbers[i]] = i + 1;
        }
        return new int[0];
    }
}
