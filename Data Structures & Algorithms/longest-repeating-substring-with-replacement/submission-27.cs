public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int[] count = new int[26];
        int res = 0;
        int max = 0;
        int left = 0;
        
        for(int i = 0; i <s.Length; i++)
        {
            int index = s[i] - 'A';
            count[index]++;
            max = Math.Max(max,count[index]);

            int window = i - left + 1;
            int replace = window - max;

            if(replace > k)
            {
                count[s[left] - 'A']--;
                left++;
            }
            res = Math.Max(res, i - left + 1);
        }
        return res;
    }
}
