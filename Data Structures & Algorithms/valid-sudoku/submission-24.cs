public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        for(int r = 0; r <9; r++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i <9; i++)
            {
                if(board[r][i] == '.')
                continue;

                if(seen.Contains(board[r][i]))
                return false;

                seen.Add(board[r][i]);
            }
        }
        for(int c = 0; c < 9; c++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i <9; i++)
            {
                if(board[i][c] == '.')
                continue;

                if(seen.Contains(board[i][c]))
                return false;
                seen.Add(board[i][c]);
            }
        }
        for(int s = 0; s <9; s++)
        {
            HashSet<char> seen = new HashSet<char>();
            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j <3; j++)
                {
                    int r = (s/3)*3 + i;
                    int c = (s%3)*3 + j;
                    if(board[r][c] == '.')
                    continue;

                    if(seen.Contains(board[r][c]))
                    return false;
                    seen.Add(board[r][c]);
                }
            }
        }
        return true;
    }
}
