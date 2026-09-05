public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(map.ContainsKey(num))
            map[num]++;

            else
            map[num] = 1;
        }
        var list = map.ToList();
        list.Sort((a,b) =>b.Value.CompareTo(a.Value));
        int[] result = new int[k];

        for(int i = 0; i <k; i++)
        {
            result[i] = list[i].Key;
        }
        return result;
    }
}
