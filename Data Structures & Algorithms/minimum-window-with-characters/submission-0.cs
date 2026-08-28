public class Solution {
    public string MinWindow(string s, string t) {
        
        int[] need = new int[128];

        foreach(char c in t)
         need[c]++;
        
        int left = 0, count = 0;
        int start = 0, min = int.MaxValue;

        for(int right = 0; right < s.Length; right++)
        {
            if(need[s[right]]>0)
            count++;

            need[s[right]]--;

            while(count == t.Length)
            {
                if(right - left + 1 < min)
                {
                    min = right - left +1;
                    start = left;
                }
                need[s[left]]++;

                if(need[s[left]]>0)
                count --;

                left ++;
            }
        } 
        return min == int.MaxValue ? "" : s.Substring(start, min);

    }
}
