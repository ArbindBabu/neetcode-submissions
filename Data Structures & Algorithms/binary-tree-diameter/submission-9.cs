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

        int left = height(root.left);
        int right = height(root.right);
        int diameter = left + right;
        int sub = Math.Max(DiameterOfBinaryTree(root.left),
         DiameterOfBinaryTree(root.right));
         return Math.Max(diameter, sub);
    }
    public int height(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        return 1+ Math.Max(height(root.left),height(root.right));
    }
}
