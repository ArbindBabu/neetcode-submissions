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
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> LevelOrder(TreeNode root) {
        
        dfs(root,0);
        return res;
    }
    private void dfs(TreeNode root, int depth)
    {
       // int depth = 0;
        if(root == null)
        {
            return;
        }
        if(res.Count == depth)
        {
            res.Add(new List<int>());
        }
        res[depth].Add(root.val);
        dfs(root.left, depth + 1);
        dfs(root.right, depth + 1);
    }
}
