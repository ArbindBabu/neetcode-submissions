public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int res = 0;
        HashSet<char> seen = new HashSet<char>(s);
        foreach(char c in seen)
        {
            int count = 0, l = 0;
            for(int r = 0; r< s.Length; r++)
            {
                if(s[r] == c)
                {
                    count++;
                }
                while((r - l + 1) - count > k)
                {
                    if(s[l] == c)
                    {
                        count--;
                    }
                    l++;
                }
                res = Math.Max(res, r - l + 1);
            }
        }
        return res;
    }
}
