public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int length1 = nums1.Length;
        int length2 = nums2.Length;

        int[] merged = new int[length1 + length2];
        Array.Copy(nums1,merged,length1);
        Array.Copy(nums2,0,merged,length1,length2);
        Array.Sort(merged);

        int totalLength = merged.Length;

        if(totalLength % 2 == 0)
        {
            return (merged[totalLength/2-1] + merged[totalLength/2])/2.0;
        }
        else
        {
            return merged[totalLength / 2];
        }
    }
}
