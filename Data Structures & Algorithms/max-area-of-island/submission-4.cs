public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        int row = grid.Length;
        int col = grid[0].Length;
        int maxArea = 0;

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j <col; j++)
            {
                if(grid[i][j] == 1)
                {
                    int currentArea = Dfs(grid, i, j);
                    maxArea = Math.Max(maxArea,currentArea);
                }
            }
        }
        return maxArea;
    }
    private int Dfs(int[][]grid, int i, int j)
    {
    if(i <0 || j <0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == 0)
        {
            return 0;
        }
        grid[i][j] = 0;
        int maxArea = 1;
        
        maxArea += Dfs(grid, i +1, j);
        maxArea += Dfs(grid, i -1, j);
        maxArea += Dfs(grid, i, j +1);
        maxArea += Dfs(grid, i, j -1);

        return maxArea;
    }
}
