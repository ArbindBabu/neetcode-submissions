public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int l1 = nums1.Length;
        int l2 = nums2.Length;
        int[] merged = new int[l1 + l2];
        
        Array.Copy(nums1,merged,l1);
        Array.Copy(nums2,0,merged,l1,l2);
        Array.Sort(merged);

        int totalLength = merged.Length;

        if(totalLength % 2 == 0)
        {
            return (merged[totalLength/2-1] + merged[totalLength/2])/2.0;
        }
        else
        {
            return merged[totalLength/2];
        }
    }
}
