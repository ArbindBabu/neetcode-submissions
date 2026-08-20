public class KthLargest {
    private List<int> arr;
    private int k;

    public KthLargest(int k, int[] nums) {
      arr = new List<int>(nums);
      this.k = k;   
    }
    
    public int Add(int val) {
       arr.Add(val);
       arr.Sort();
       return arr[arr.Count - k];    
    }
}
