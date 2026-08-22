public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            string sorteds = new string (ch);
            if(!res.ContainsKey(sorteds))
            {
               res[sorteds] = new List<string>();
            }
            res[sorteds].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
