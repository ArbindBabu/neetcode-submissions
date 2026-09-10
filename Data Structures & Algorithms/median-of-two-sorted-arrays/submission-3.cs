public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int length1 = nums1.Length;
        int length2 = nums2.Length;
        int[] merged = new int[length1 + length2];

        Array.Copy(nums1,merged,length1);
        Array.Copy(nums2,0,merged,length1,length2);
        Array.Sort(merged);

        int totallength = merged.Length;
        if(totallength % 2 == 0)
        {
            return(merged[totallength /2 -1] + merged[totallength/2])/2.0;
        }
        else
        {
            return merged[totallength/2];
        }
    }
}
