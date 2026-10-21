public class Solution {
    public int NumIslands(char[][] grid) {
        
        int row  = grid.Length;
        int col = grid[0].Length;
        int island = 0;

        for(int i = 0; i <row; i++)
        {
            for(int j = 0; j <col; j++)
            {
                if(grid[i][j] == '1')
                {
                    Dfs(grid,i,j);
                    island++;
                }
            }
        }
        return island;
    }
    private void Dfs(char[][] grid, int i, int j)
    {
    if(i <0 || j <0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] =='0')
        {
            return;
        }
        grid[i][j] = '0';
        Dfs(grid, i+1, j);
        Dfs(grid, i-1, j);
        Dfs(grid, i, j+1);
        Dfs(grid, i, j-1);
    }
}
