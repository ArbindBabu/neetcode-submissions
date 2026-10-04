public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        int n = position.Length;
        int[][] cars = new int[n][];

        for(int i = 0; i <n; i++)
        {
            cars[i] = new int[]{position[i], speed[i]};
        }
        Array.Sort(cars,(a,b) =>b[0].CompareTo(a[0]));
        List<double> fleetime = new List<double>();

        foreach(int[] car in cars)
        {
            double time = (double)(target - car[0])/ car[1];

            if(fleetime.Count == 0 || time >fleetime[fleetime.Count - 1])
            {
                fleetime.Add(time);
            }
        }
        return fleetime.Count;
    }
}
