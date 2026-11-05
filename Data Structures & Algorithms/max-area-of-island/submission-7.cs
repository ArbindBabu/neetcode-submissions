public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        int row = grid.Length;
        int col = grid[0].Length;
        int maxArea = 0;

        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                if(grid[r][c] == 1)
                {
                    int area = Dfs(grid, r, c);
                    maxArea = Math.Max(maxArea,area);
                }
            }
        }
        return maxArea;
    }
    private int Dfs(int[][] grid, int r, int c)
    {
        if(r <0 || c <0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == 0)
        {
            return 0;
        }
        grid[r][c] = 0;
        int maxArea = 1;

        maxArea += Dfs(grid, r+1, c);
        maxArea += Dfs(grid, r-1, c);
        maxArea += Dfs(grid, r, c+1);
        maxArea += Dfs(grid, r, c-1); 
        return maxArea;
    }
}
