/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<Node, Node> OldToNew = new Dictionary<Node, Node>();
        return Dfs(node, OldToNew);
    }
    private Node Dfs(Node node, Dictionary<Node, Node> OldToNew)
    {
        if(node == null)
         return null;
        
        if(OldToNew.ContainsKey(node))
        
            return OldToNew[node];

            Node copy = new Node(node.val);
            OldToNew[node] = copy;

            foreach(Node nei in node.neighbors)
            copy.neighbors.Add(Dfs(nei, OldToNew));
        
        return copy;
    }
}
