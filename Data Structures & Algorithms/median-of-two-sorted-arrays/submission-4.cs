public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int l1 = nums1.Length;
        int l2 = nums2.Length;
        int[] merged = new int[l1 + l2];
        
        Array.Copy(nums1,merged,l1);
        Array.Copy(nums2,0,merged,l1,l2);
        Array.Sort(merged);

        int totallen = merged.Length;
        if(totallen % 2 == 0)
        {
            return (merged[totallen / 2-1] + merged[totallen/2])/2.0;
        }
        else
        {
            return merged[totallen/2];
        }
    }
}
