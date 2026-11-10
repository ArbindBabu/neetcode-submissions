public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var res = new Dictionary<string,List<string>>();
        foreach(var s in strs)
        {
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            string Sorted = new string(ch);
        
         if(!res.ContainsKey(Sorted))
         {
            res[Sorted] = new List<string>();
         }
         res[Sorted].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
