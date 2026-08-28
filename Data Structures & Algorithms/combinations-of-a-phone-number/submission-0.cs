public class Solution {
    public List<string> LetterCombinations(string digits) {
        
        if(digits.Length == 0)
            return new List<string>();

            string[] phone = 
            {
                "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"
            };
            List<string> result = new (){ "" };
            foreach(char digit in digits)
            {
                List<string> next = new();

                foreach(string str in result)
                {
                    foreach(char c in phone[digit - '0'])
                    {
                        next.Add(str + c);
                    }
                }
                result = next;
            }
            return result;

    }
}
