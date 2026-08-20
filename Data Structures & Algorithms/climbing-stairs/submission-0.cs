public class Solution 
{
    public int ClimbStairs(int n) 
    {     
        int i,temp=0,one=1,two=1;
        for(i = 0; i < n-1; i++)
        {
            temp = one;
            one = one + two;
            two = temp;
        }
        return one;
    }
}
