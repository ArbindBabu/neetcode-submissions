public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] arr = nums1.Concat(nums2).OrderBy(x => x).ToArray();

    int n = arr.Length;

    if (n % 2 == 1)
        return arr[n / 2];

    return (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
    }
}
