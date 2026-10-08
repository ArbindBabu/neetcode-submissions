public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length)
        {
            return false;
        }
        int[]s1count = new int[26];
        int[]s2count = new int[26];
        
        for(int i = 0; i <s1.Length; i++)
        {
            s1count[s1[i] - 'a']++;
            s2count[s2[i] - 'a']++;
        }
        if(s1count.SequenceEqual(s2count))
        {
            return true;
        }
        for(int i = s1.Length; i <s2.Length; i++)
        {
            s2count[s2[i] - 'a']++;
            s2count[s2[i - s1.Length]- 'a']--;

            if(s1count.SequenceEqual(s2count))
            {
                return true;
            }
        }
        return false;
    }
}
