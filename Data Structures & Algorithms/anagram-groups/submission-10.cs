public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var res = new Dictionary<string,List<string>>();
        foreach(var str in strs)
        {
            char[] ch = str.ToCharArray();
            Array.Sort(ch);
            string sorted = new string(ch);

            if(!res.ContainsKey(sorted))
            {
                res[sorted] = new List<string>();
            }
            res[sorted].Add(str);
        }
        return res.Values.ToList<List<string>>();
    }
}
