public class Solution 
{
    public void ReverseString(char[] s) 
    {
        Reverse(s,0,s.Length - 1);
    }
    private void Reverse(char[] s, int left, int right)
    {
        if(left < right)
        {
            Reverse(s,left +1, right-1);
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
        }
    }
}