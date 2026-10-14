public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        int area = 0;

        for(int r = 0; r <rows; r++)
        {
            for(int c = 0; c <cols; c++)
            {
                if(grid[r][c] == 1)
                {
                    int currentArea = DFS(grid, r, c);
                    area = Math.Max(area,currentArea);
                }
            }
        }
        return area;
    }
    private int DFS(int[][]grid,int r,int c)
    {
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[r].Length
        || grid[r][c] == 0 )
        {
            return 0;
        }
        grid[r][c] = 0;
        int area = 1;

        area += DFS(grid, r+1, c);
        area += DFS(grid, r-1, c);
        area += DFS(grid, r, c+1);
        area += DFS(grid, r, c-1);

        return area;
    }
}
