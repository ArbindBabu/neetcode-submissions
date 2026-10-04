public class Solution {
    public string LongestPalindrome(string s) {
        
        string str ="";
        int resLength = 0;

        for(int i = 0; i <s.Length; i++)
        {
            for(int j = i; j <s.Length; j++)
            {
                int l = i, r = j;

                while(l < r && s[l] == s[r])
                {
                    l++;
                    r--;
                }
                if(l >= r && resLength <(j - i + 1))
                {
                    str = s.Substring(i,j-i+1);
                    resLength = j-i+1;
                }
            }
        }
        return str;
    }
}
