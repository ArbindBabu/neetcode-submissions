public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
        {
            return false;
        }
        char[] sArray = s.ToArray();
        char[] tArray = t.ToArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string (sArray) == new string (tArray);
    }
}
