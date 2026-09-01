public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
         Array.Sort(candidates);

        var result = new List<List<int>>();

        void DFS(int start, int target, List<int> path)
        {
            if (target == 0)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;

                if (candidates[i] > target)
                    break;

                path.Add(candidates[i]);

                DFS(i + 1, target - candidates[i], path);

                path.RemoveAt(path.Count - 1);
            }
        }

        DFS(0, target, new List<int>());

        return result;
    }
}
