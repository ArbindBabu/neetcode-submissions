public class Solution {
    public bool IsPalindrome(string s) {
        
        string newstr = "";
        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                newstr += char.ToLower(c);
            }
        }
        return newstr == new string(newstr.Reverse().ToArray());
    }
}
