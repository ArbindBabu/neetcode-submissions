public class Solution {
    private int rows, cols;
    private bool[,] visited;
    public bool Exist(char[][] board, string word) 
    {
        rows = board.Length;
        cols = board[0].Length;
        visited = new bool[rows,cols];

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(Dfs(board, word, r, c, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }
    private bool Dfs(char[][] board, string word, int r, int c, int i)
    {
        if(i == word.Length)
        {
            return true;
        }
        if(r < 0 || c < 0 || 
           r >= rows || c >= cols ||
           board[r][c] != word[i] || 
           visited[r, c])
           {
            return false;
           }
           visited[r, c] = true;
           bool res = Dfs(board, word, r+1, c, i+1)||
                      Dfs(board, word, r-1, c, i+1)||
                      Dfs(board, word, r, c+1, i+1)||
                      Dfs(board, word, r, c-1, i+1);
            visited[r, c] = false;
            return res;
    }
}
