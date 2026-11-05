public class Solution {
    public int NumIslands(char[][] grid) {
        
        int row = grid.Length;
        int col = grid[0].Length;
        int island = 0;

        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                if(grid[r][c] == '1')
                {
                    Dfs(grid,r,c);
                    island++;
                }
            }
        }
        return island;
    } 
    private void Dfs(char[][] grid, int r, int c)
    {
    if(r <0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0')
        {
            return;
        }
        grid[r][c] = '0';
        Dfs(grid, r+1, c);
        Dfs(grid, r-1, c);
        Dfs(grid, r, c+1);
        Dfs(grid, r, c-1);
    }
}
