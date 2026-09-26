/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxPathSum(TreeNode root) {
        
        int res = root.val;
        dfs(root, ref res);
        return res;
    }
    private int dfs(TreeNode root, ref int res)
    {
        if(root == null)
        {
            return 0;
        }
        int left = Math.Max(dfs(root.left, ref res),0);
        int right = Math.Max(dfs(root.right, ref res), 0);

        res = Math.Max(res,root.val + left + right);
        return root.val + Math.Max(left,right);
    }
}
