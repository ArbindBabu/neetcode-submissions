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
    public int DiameterOfBinaryTree(TreeNode root) {
        
        if(root == null)
        {
            return 0;
        }
        int left = Height(root.left);
        int right = Height(root.right);
        int diameter = left + right;
        int sub = Math.Max(DiameterOfBinaryTree(root.left), 
        DiameterOfBinaryTree(root.right));
        return Math.Max(sub,diameter);
    }
    public int Height(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        return 1+ Math.Max(Height(root.left),Height(root.right));
    }
}
