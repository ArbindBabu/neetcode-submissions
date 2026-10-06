public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var res = new Dictionary<string,List<string>>();
        foreach(string s in strs)
        {
            char[] ch = s.ToArray();
            Array.Sort(ch);
            string sort = new string(ch);

            if(!res.ContainsKey(sort))
            {
                res[sort] = new List<string>();
            }
            res[sort].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
