public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length)
        {
            return false;
        }
         int[] a = new int[26];
         int[] b = new int[26];

         for(int i = 0; i < s1.Length; i++)
         {
            a[s1[i] - 'a']++;
            b[s2[i] - 'a']++;
         }
         for(int i = s1.Length; i < s2.Length; i++)
         {
            if(a.SequenceEqual(b))
            return true;
            
                b[s2[i] - 'a']++;
                b[s2[i - s1.Length] - 'a']--;
            
         }
         return a.SequenceEqual(b);
    }
}
