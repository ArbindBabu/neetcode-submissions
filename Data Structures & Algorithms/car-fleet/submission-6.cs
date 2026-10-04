public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        int n = position.Length;
        int[][] cars = new int[n][];

        for(int i = 0; i <n; i++)
        {
            cars[i] = new int[]{position[i], speed[i]}; 
        }
        Array.Sort(cars,(a,b) => b[0].CompareTo(a[0]));
        List<double> fleetTimes = new List<double>();
        
        foreach(int[] car in cars)
        {
            double time = (double)(target - car[0])/car[1];

            if(fleetTimes.Count == 0 || time > fleetTimes[fleetTimes.Count - 1])
            {
                fleetTimes.Add(time);
            }
        }
        return fleetTimes.Count;
    }
}
