public class Solution 
{
    public void SetZeroes(int[][] matrix) 
    {
        int row = matrix.Length;
        int col = matrix[0].Length;

        bool[] rowZero = new bool[row];
        bool[] colZero = new bool[col];

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                if(matrix[i][j] == 0)
                {
                    rowZero[i] = true;
                    colZero[j] = true;
                }
            }
        }
        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                if(rowZero[r] || colZero[c])
                {
                    matrix[r][c] = 0;
                }
            }
        }
    }
}
