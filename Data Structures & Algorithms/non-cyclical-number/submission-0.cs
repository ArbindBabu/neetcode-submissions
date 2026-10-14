public class Solution 
{
    public bool IsHappy(int n) 
    {
         HashSet<int> visit = new HashSet<int>();

        while (n != 1)
        {
            if (!visit.Add(n))
                return false;

            n = SumOfSquares(n);
        }

        return true;
    }
   private int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}
