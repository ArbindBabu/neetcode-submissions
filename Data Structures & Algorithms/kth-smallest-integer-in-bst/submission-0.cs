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
    public int KthSmallest(TreeNode root, int k) {
        List<int> array = new List<int>();
        Dfs(root, array);
        array.Sort();
        return array[k - 1];
    }
    private void Dfs(TreeNode node, List<int> array)
    {
        if(node == null)
        return;

        array.Add(node.val);
        Dfs(node.left,array);
        Dfs(node.right,array);
    }
}
