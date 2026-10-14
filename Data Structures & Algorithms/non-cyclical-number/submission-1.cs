public class Solution {
    public bool IsHappy(int n) {
        
        int slow = n, fast = sum(n);

        while(slow != fast)
        {
            fast = sum(fast);
            fast = sum(fast);
            slow = sum(slow);

        }
        return fast == 1;
    }
    private int sum(int n)
    {
        int op = 0;
        while( n != 0)
        {
            op += (n%10) *(n%10);
            n /= 10;
        }
        return op;
    }
}
