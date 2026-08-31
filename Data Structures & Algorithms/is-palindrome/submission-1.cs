public class Solution {
    public bool IsPalindrome(string s) {
        
        string str = "";

        foreach(char c in s )
        {
            if(char.IsLetterOrDigit(c))
            {
                str += char.ToLower(c);
            }
        }
        return str == new string(str.Reverse().ToArray());
    }
}
