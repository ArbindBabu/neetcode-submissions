public class Solution {
    public string Multiply(string num1, string num2) {
        
        if(num1 == "0" || num2 == "0")
        {
            return "0";
        }
        int m = num1.Length;
        int n = num2.Length;

        int[] result = new int[m + n];
        for(int i = m-1; i >=0; i--)
        {
            for(int j = n-1; j >=0; j--)
            {
                int digit1 = num1[i] - '0';
                int digit2 = num2[j] - '0';

                int product = digit1 * digit2;
                int sum = product + result[i+j +1];
                result[i +j+1] = sum % 10;
                result[i + j] += sum/10;
            }
        }
        string answer = "";

        foreach(int digit in result)
        {
            if(answer.Length > 0 || digit != 0)
            {
                answer += digit;
            }
        }
        return answer;
    }
}
