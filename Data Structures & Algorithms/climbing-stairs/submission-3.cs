public class Solution {
    public int ClimbStairs(int n) {     
        
        int i = 0;
        int temp = 0;
        int  one = 1;
        int  two = 0;
        for(i = 0; i <n; i++)
        {
            temp = one;
            one = one + two;
            two = temp;         
        }
        return one;
    }
}
