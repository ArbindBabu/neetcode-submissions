public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        int fresh = 0, time = 0;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 1)
                fresh++;
            }
        } 
        int[][] direction = new int[][]
        {
            new int[] {0, 1}, new int[]{0, -1},
            new int[] {1, 0}, new int[]{-1,0}
        };
        while(fresh > 0)
        {
            bool flag = false;
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    if(grid[r][c] == 2)
                    {
                        foreach(var d in direction)
                        {
                            int row = r + d[0], col = c + d[1];
                            if(row >=0 && col >= 0 && row < rows && col < cols
                             && grid[row][col] == 1)
                             {
                                grid[row][col] = 3;
                                fresh--;
                                flag = true;
                             }
                        }
                    }
                }
            }
            if(!flag)
            return -1;

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    if(grid[r][c] == 3) grid[r][c] = 2;
                }
            }
            time ++;
        }
        return time;
    }
}
