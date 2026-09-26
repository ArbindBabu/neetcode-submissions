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
    public int GoodNodes(TreeNode root) {
        return Dfs(root, root.val);
    }
    private int Dfs(TreeNode node, int maxval)
    {
        if(node == null)
        {
            return 0;
        }
        int res = (node.val >= maxval) ? 1 : 0;
        maxval = Math.Max(maxval, node.val);
        res += Dfs(node.left,maxval);
        res += Dfs(node.right, maxval);
        return res;
    }
}
