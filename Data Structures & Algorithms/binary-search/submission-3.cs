public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        return BinarySearch(0, nums.Length-1, nums, target);
    }
    public int BinarySearch(int left, int right, int[] nums, int target)
    {
        if(left > right)
        return -1;
        int mid = left + (right - left)/ 2;

        if(nums[mid] == target)
        return mid;
        return(nums[mid] < target) ?
        BinarySearch( mid + 1, right, nums, target):
        BinarySearch( left, mid - 1, nums, target);
    }
}
