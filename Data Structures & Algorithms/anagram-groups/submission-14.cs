public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var res = new Dictionary<string,List<string>>();
        foreach(string str in strs)
        {
            char[] ch = str.ToArray();
            Array.Sort(ch);
            string sort = new string(ch);

            if(!res.ContainsKey(sort))
            {
                res[sort] = new List<string>();
            }
            res[sort].Add(str);
        }
        return res.Values.ToList<List<string>>();
    }
}
