public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int m  = matrix.Length;

        for(int row = 0; row <m; row++)
        {
          for(int col = 0; col <matrix[row].Length; col++)
          {
            if(matrix[row][col] == target)
            {
              return true;
            }
          }
        }
        return false;
    }
}
