public class Solution 
{
    public int CountSeniors(string[] details) 
    {
        int res = 0;
        foreach(string d in details)
        {
            int ten = d[11] - '0';
            int one = d[12] - '0';
            int age = one + 10 * ten;
            if(age > 60)
            {
                res++;
            }
        }
        return res;
    }
}