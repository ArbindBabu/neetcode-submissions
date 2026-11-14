public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int[] count = new int[26];
        int result = 0;
        int max = 0;
        int left = 0;

        for(int right = 0; right <s.Length; right++)
        {
            int index = s[right]- 'A';
            count[index]++;
            max = Math.Max(max,count[index]);

            int window = right - left + 1;
            int replace = window - max;

            if(replace > k)
            {
                count[s[left] - 'A']--;
                left++;
            }
            result = Math.Max(result,right - left + 1);
        }
        return result;
    }
}
