public class Solution {
    public int NumIslands(char[][] grid) {
        
        int row = grid.Length;
        int col = grid[0].Length;
        int island = 0;

        for(int rows = 0; rows <row; rows++)
        {
            for(int cols = 0; cols< col; cols++)
            {
                if(grid[rows][cols] == '1')
                {
                    Dfs(grid,rows,cols);
                    island++;
                }
            }
        }
        return island;
    }
    private void Dfs(char[][]grid,int rows, int cols)
    {
        if(rows < 0 || cols < 0 || rows >= grid.Length || cols >= grid[0].Length ||
        grid[rows][cols] == '0')
        {
            return;
        }
        grid[rows][cols] = '0';
        Dfs(grid, rows +1, cols);
        Dfs(grid, rows -1, cols);
        Dfs(grid, rows, cols +1);
        Dfs(grid, rows, cols -1);
    }
}
