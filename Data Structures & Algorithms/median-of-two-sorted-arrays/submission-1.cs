public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int leng1 = nums1.Length;
        int leng2 = nums2.Length;

        int[] merged = new int[leng1 + leng2];

        Array.Copy(nums1, merged, leng1);
        Array.Copy(nums2, 0, merged,leng1, leng2);
        Array.Sort(merged);

        int totalen = merged.Length;
        if(totalen % 2 == 0)
        {
            return (merged[totalen/2-1] + merged[totalen/2])/2.0;
        }
        else
        {
            return merged[totalen/2];
        }
    }
}
