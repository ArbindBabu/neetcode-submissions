public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<List<string>> res = new List<List<string>>();
        for(int i = 0; i <=n; i++)
        {
            res.Add(new List<string>());
        }
        res[0].Add("");

        for(int j = 0; j <= n; j++)
        {
            for(int i = 0; i < j; i++)
            {
                foreach(string left in res[i])
                {
                    foreach(string right in res[j - i - 1])
                    {
                        res[j].Add("("+left+")" + right);
                    }
                }
            }
        }
        return res[n];
    }
}
