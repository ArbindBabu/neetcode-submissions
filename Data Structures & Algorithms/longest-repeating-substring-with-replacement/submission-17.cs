public class Solution {
    public int CharacterReplacement(string s, int k) {
         int[] count = new int[26];

        int left = 0;
        int maxFreq = 0;
        int result = 0;

        for (int right = 0; right < s.Length; right++)
        {
            int index = s[right] - 'A';

            count[index]++;

            maxFreq = Math.Max(maxFreq, count[index]);

            int windowLength = right - left + 1;

            int replacements = windowLength - maxFreq;

            if (replacements > k)
            {
                count[s[left] - 'A']--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
