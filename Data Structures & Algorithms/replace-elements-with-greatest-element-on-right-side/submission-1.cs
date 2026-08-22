public class Solution {
    public int[] ReplaceElements(int[] arr) 
    {
        int i;
        int n = arr.Length;
        int[] ans = new int[n];
        int rightMax = -1;

        for(i = n-1; i >=0; i--)
        {
            ans[i] = rightMax;
            rightMax = Math.Max(arr[i], rightMax);
        }
        return ans;
    }
}