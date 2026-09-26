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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        TreeNode res = root;
        while(res != null)
        {
            if(p.val > res.val && q.val > res.val)
            {
                res = res.right;
            }
            else if(p.val < res.val && q.val < res.val)
            {
                res = res.left;
            }
            else{
                return res;
            }

        }
        return null;
    }
}
